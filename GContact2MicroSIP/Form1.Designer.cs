namespace GContact2MicroSIP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Step1Label = new System.Windows.Forms.Label();
            this.ImportFileName = new System.Windows.Forms.TextBox();
            this.OpenInputFileButton = new System.Windows.Forms.Button();
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.ReadContactsButton = new System.Windows.Forms.Button();
            this.OpenContactFileButton = new System.Windows.Forms.Button();
            this.SaveFileName = new System.Windows.Forms.TextBox();
            this.Step2Label = new System.Windows.Forms.Label();
            this.WriteContactsButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.Step3Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Step1Label
            // 
            this.Step1Label.AutoSize = true;
            this.Step1Label.Location = new System.Drawing.Point(28, 13);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(153, 13);
            this.Step1Label.TabIndex = 0;
            this.Step1Label.Text = "1) Google Kontakte importieren";
            // 
            // ImportFileName
            // 
            this.ImportFileName.Location = new System.Drawing.Point(31, 44);
            this.ImportFileName.Name = "ImportFileName";
            this.ImportFileName.Size = new System.Drawing.Size(388, 20);
            this.ImportFileName.TabIndex = 1;
            // 
            // OpenInputFileButton
            // 
            this.OpenInputFileButton.Location = new System.Drawing.Point(426, 40);
            this.OpenInputFileButton.Name = "OpenInputFileButton";
            this.OpenInputFileButton.Size = new System.Drawing.Size(28, 23);
            this.OpenInputFileButton.TabIndex = 2;
            this.OpenInputFileButton.Text = "...";
            this.OpenInputFileButton.UseVisualStyleBackColor = true;
            this.OpenInputFileButton.Click += new System.EventHandler(this.OpenInputFileButton_Click);
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Enabled = false;
            this.ReadFileButton.Location = new System.Drawing.Point(487, 40);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(106, 23);
            this.ReadFileButton.TabIndex = 3;
            this.ReadFileButton.Text = "Quelldatei einlesen";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // ReadContactsButton
            // 
            this.ReadContactsButton.Enabled = false;
            this.ReadContactsButton.Location = new System.Drawing.Point(487, 118);
            this.ReadContactsButton.Name = "ReadContactsButton";
            this.ReadContactsButton.Size = new System.Drawing.Size(106, 23);
            this.ReadContactsButton.TabIndex = 7;
            this.ReadContactsButton.Text = "Zieldatei auswählen";
            this.ReadContactsButton.UseVisualStyleBackColor = true;
            this.ReadContactsButton.Click += new System.EventHandler(this.ReadContactsButton_Click);
            // 
            // OpenContactFileButton
            // 
            this.OpenContactFileButton.Enabled = false;
            this.OpenContactFileButton.Location = new System.Drawing.Point(426, 118);
            this.OpenContactFileButton.Name = "OpenContactFileButton";
            this.OpenContactFileButton.Size = new System.Drawing.Size(28, 23);
            this.OpenContactFileButton.TabIndex = 6;
            this.OpenContactFileButton.Text = "...";
            this.OpenContactFileButton.UseVisualStyleBackColor = true;
            this.OpenContactFileButton.Click += new System.EventHandler(this.OpenContactFileButton_Click);
            // 
            // SaveFileName
            // 
            this.SaveFileName.Enabled = false;
            this.SaveFileName.Location = new System.Drawing.Point(31, 122);
            this.SaveFileName.Name = "SaveFileName";
            this.SaveFileName.Size = new System.Drawing.Size(388, 20);
            this.SaveFileName.TabIndex = 5;
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.Location = new System.Drawing.Point(28, 91);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(154, 13);
            this.Step2Label.TabIndex = 4;
            this.Step2Label.Text = "2) MicroSIP Adressbuch öffnen";
            // 
            // WriteContactsButton
            // 
            this.WriteContactsButton.Enabled = false;
            this.WriteContactsButton.Location = new System.Drawing.Point(487, 196);
            this.WriteContactsButton.Name = "WriteContactsButton";
            this.WriteContactsButton.Size = new System.Drawing.Size(106, 23);
            this.WriteContactsButton.TabIndex = 11;
            this.WriteContactsButton.Text = "Kontakte ergänzen";
            this.WriteContactsButton.UseVisualStyleBackColor = true;
            this.WriteContactsButton.Click += new System.EventHandler(this.WriteContactsButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StatusBox.Enabled = false;
            this.StatusBox.Location = new System.Drawing.Point(31, 200);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(423, 20);
            this.StatusBox.TabIndex = 9;
            this.StatusBox.Text = "0 Kontakte mit 0 Telefonnummern gefunden.";
            // 
            // Step3Label
            // 
            this.Step3Label.AutoSize = true;
            this.Step3Label.Location = new System.Drawing.Point(28, 169);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(181, 13);
            this.Step3Label.TabIndex = 8;
            this.Step3Label.Text = "3) Kontakte im Adressbuch ergänzen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Beenden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(348, 276);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(106, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Zurücksetzen";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(31, 400);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Icon made by Freepik from www.flaticon.com ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(430, 400);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(163, 13);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Webseite und Erklärung aufrufen";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WriteContactsButton);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.Step3Label);
            this.Controls.Add(this.ReadContactsButton);
            this.Controls.Add(this.OpenContactFileButton);
            this.Controls.Add(this.SaveFileName);
            this.Controls.Add(this.Step2Label);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.OpenInputFileButton);
            this.Controls.Add(this.ImportFileName);
            this.Controls.Add(this.Step1Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GContact2MicroSIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Step1Label;
        private System.Windows.Forms.TextBox ImportFileName;
        private System.Windows.Forms.Button OpenInputFileButton;
        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.Button ReadContactsButton;
        private System.Windows.Forms.Button OpenContactFileButton;
        private System.Windows.Forms.TextBox SaveFileName;
        private System.Windows.Forms.Label Step2Label;
        private System.Windows.Forms.Button WriteContactsButton;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Label Step3Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

