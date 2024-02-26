using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GContact2MicroSIP
{
    public partial class Form1 : Form
    {
        public List<Entry> Entries { get; set; }

        public Form1 ()
        {
            InitializeComponent();
            Entries = new List<Entry>();
        }

        private void OpenInputFileButton_Click (object sender, EventArgs e)
        {
            StatusBox.Text = string.Empty;
            var ofd = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                DefaultExt = ".vcf",
                Filter = "Adressbuch (*.vcf)|*.vcf"
            };
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK && File.Exists(ofd.FileName))
            {
                ImportFileName.Text = ofd.FileName;
                ReadFileButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sie haben keine Datei ausgewählt.");
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            ActiveForm?.Close();
        }

        private void ReadFileButton_Click (object sender, EventArgs e)
        {
            var countNames = 0;
            var countNumbers = 0;
            using (var myFile = new StreamReader(ImportFileName.Text))
            {
                string line;
                var name = string.Empty;
                while ((line = myFile.ReadLine()) != null)
                {
                    if (line.StartsWith("FN"))
                    {
                        name = line.Substring(line.LastIndexOf(":", StringComparison.Ordinal) + 1);
                        countNames++;
                    }
                    if (!line.StartsWith("TEL") || line.Contains("FAX")) continue;
                    var telType = string.Empty;
                    if (line.LastIndexOf("TYPE", StringComparison.Ordinal) > 0)
                    {
                        telType = line.Substring(line.LastIndexOf("TYPE", StringComparison.Ordinal)+5,4);
                    }
                    var telNumber = line.Substring(line.LastIndexOf(":", StringComparison.Ordinal)+1);
                    Entries.Add(new Entry($"{name} {telType}", telNumber));
                    countNumbers++;
                }
            }
            StatusBox.Text = $"{countNames} Kontakte mit {countNumbers} Telefonnummern gefunden.";
            SaveFileName.Enabled = true;
            OpenContactFileButton.Enabled = true;
        }

        private void OpenContactFileButton_Click (object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+@"\MicroSIP",
                DefaultExt = ".xml",
                Filter = "XML Datei (*.xml)|*.xml",
                FileName = "Contacts.xml"
            };
            var result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                SaveFileName.Text = sfd.FileName;
                ReadContactsButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sie haben keine Datei ausgewählt.");
            }
        }

        private void ReadContactsButton_Click(object sender, EventArgs e)
        {
            var myFileName = SaveFileName.Text;
            if (File.Exists(myFileName))
            {
                XDocument document = XDocument.Load(myFileName);
                var docCount = document.Descendants().Count()-1;
                StatusBox.Text += $" {docCount} alte Datensätze gefunden.";
            }
            WriteContactsButton.Enabled = true;
        }

        private void WriteContactsButton_Click (object sender, EventArgs e)
        {
            var myFileName = SaveFileName.Text;
            var xmlTree = new XElement("contacts");
            XDocument document;
            if (File.Exists(myFileName))
            {
                document = XDocument.Load(myFileName);
                xmlTree = document.Element("contacts") ?? new XElement("contacts");
                File.Move(myFileName,myFileName+DateTime.Now.ToString("yyyyMMddHHmmss"));
            }
            var element = new XElement("contact", string.Empty);
            foreach (var entry in Entries)
            {
                element.SetAttributeValue("name", entry.Name);
                element.SetAttributeValue("number", entry.Phone);
                element.SetAttributeValue("firstname", string.Empty);
                element.SetAttributeValue("lastname", string.Empty);
                element.SetAttributeValue("phone", string.Empty);
                element.SetAttributeValue("mobile", string.Empty);
                element.SetAttributeValue("email", string.Empty);
                element.SetAttributeValue("address", string.Empty);
                element.SetAttributeValue("city", string.Empty);
                element.SetAttributeValue("state", string.Empty);
                element.SetAttributeValue("zip", string.Empty);
                element.SetAttributeValue("comment", string.Empty);
                element.SetAttributeValue("id", string.Empty);
                element.SetAttributeValue("info", string.Empty);
                element.SetAttributeValue("presence", entry.Presence);
                element.SetAttributeValue("directory", entry.Directory);
                element.SetAttributeValue("starred", 0);
                xmlTree.Add(element);
                element = new XElement("contact", string.Empty);
            }
            document = new XDocument(xmlTree) { Declaration = new XDeclaration("1.0", "utf-8", "true") };
            //document = new XDocument(xmlTree) { Declaration = new XDeclaration("1.0", string.Empty, "true") };
            document.Save(myFileName);
            WriteContactsButton.Enabled = false;
            SaveFileName.Enabled = false;
            SaveFileName.Text = string.Empty;
            OpenContactFileButton.Enabled = false;
            ImportFileName.Text = string.Empty;
            ReadFileButton.Enabled = false;
            ReadContactsButton.Enabled = false;
            StatusBox.Text = "Datei erfolgreich geschrieben!";
        }

        private void ResetButton_Click (object sender, EventArgs e)
        {
            WriteContactsButton.Enabled = false;
            SaveFileName.Enabled = false;
            SaveFileName.Text = string.Empty;
            OpenContactFileButton.Enabled = false;
            ImportFileName.Text = string.Empty;
            ReadFileButton.Enabled = false;
            ReadContactsButton.Enabled = false;
            StatusBox.Text = string.Empty;
        }

        private void label1_Click (object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.flaticon.com/");
        }

        private void linkLabel2_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.onkeljoe.de/google-kontakte-nach-microsip-importieren-ein-tool-zum-konvertieren/");
        }
    }
}
