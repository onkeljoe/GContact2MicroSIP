using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GContact2MicroSIP
{
    public partial class Form1 : Form
    {
        private List<Entry> _entries;

        public List<Entry> Entries
        {
            get
            {
                return _entries;
            }

            set
            {
                _entries = value;
            }
        }

        public Form1 ()
        {
            InitializeComponent();
            Entries = new List<Entry>();
        }

        private void OpenInputFileButton_Click (object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
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
                        name = line.Substring(3);
                        countNames++;
                    }
                    if (!line.StartsWith("TEL") || line.Contains("FAX")) continue;
                    var telType = line.Substring(9, 4);
                    var telNumber = line.Substring(13);
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
            //string path = System.Environment
            var sfd = new SaveFileDialog
            {
                //InitialDirectory = @"\%appdata\%\\MicroSIP",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+@"\MicroSIP",
                DefaultExt = ".xml",
                Filter = "XML Datei (*.xml)|*.xml"
            };
            var result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    //Altdaten einlesen
                }
                SaveFileName.Text = sfd.FileName;
                ReadContactsButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sie haben keine Datei ausgewählt.");
            }
        }
    }
}
