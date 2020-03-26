namespace Projekt_Patientendaten
{
    partial class FrmAdministration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttn_newPatient = new System.Windows.Forms.Button();
            this.bttn_editPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.bttn_editEntry = new System.Windows.Forms.Button();
            this.bttn_newEntry = new System.Windows.Forms.Button();
            this.lbPatients = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInsuranceAgency = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLocalDoctor = new System.Windows.Forms.Label();
            this.lblInsuranceNr = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTelNr = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTreatments = new System.Windows.Forms.ListBox();
            this.tbEntry = new System.Windows.Forms.TextBox();
            this.tbMedication = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_newPatient
            // 
            this.bttn_newPatient.Location = new System.Drawing.Point(13, 413);
            this.bttn_newPatient.Name = "bttn_newPatient";
            this.bttn_newPatient.Size = new System.Drawing.Size(111, 23);
            this.bttn_newPatient.TabIndex = 0;
            this.bttn_newPatient.Text = "Neuer Patient";
            this.bttn_newPatient.UseVisualStyleBackColor = true;
            this.bttn_newPatient.Click += new System.EventHandler(this.bttn_newPatient_Click);
            // 
            // bttn_editPatient
            // 
            this.bttn_editPatient.Location = new System.Drawing.Point(139, 413);
            this.bttn_editPatient.Name = "bttn_editPatient";
            this.bttn_editPatient.Size = new System.Drawing.Size(111, 23);
            this.bttn_editPatient.TabIndex = 1;
            this.bttn_editPatient.Text = "Patient bearbeiten";
            this.bttn_editPatient.UseVisualStyleBackColor = true;
            this.bttn_editPatient.Click += new System.EventHandler(this.bttn_editPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suche:";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(59, 376);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(191, 20);
            this.tb_search.TabIndex = 4;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // bttn_editEntry
            // 
            this.bttn_editEntry.Location = new System.Drawing.Point(390, 413);
            this.bttn_editEntry.Name = "bttn_editEntry";
            this.bttn_editEntry.Size = new System.Drawing.Size(111, 23);
            this.bttn_editEntry.TabIndex = 23;
            this.bttn_editEntry.Text = "Eintrag bearbeiten";
            this.bttn_editEntry.UseVisualStyleBackColor = true;
            this.bttn_editEntry.Click += new System.EventHandler(this.bttn_editEntry_Click);
            // 
            // bttn_newEntry
            // 
            this.bttn_newEntry.Location = new System.Drawing.Point(273, 413);
            this.bttn_newEntry.Name = "bttn_newEntry";
            this.bttn_newEntry.Size = new System.Drawing.Size(111, 23);
            this.bttn_newEntry.TabIndex = 24;
            this.bttn_newEntry.Text = "Neuer Eintrag";
            this.bttn_newEntry.UseVisualStyleBackColor = true;
            this.bttn_newEntry.Click += new System.EventHandler(this.bttn_newEntry_Click);
            // 
            // lbPatients
            // 
            this.lbPatients.FormattingEnabled = true;
            this.lbPatients.Location = new System.Drawing.Point(13, 13);
            this.lbPatients.Name = "lbPatients";
            this.lbPatients.Size = new System.Drawing.Size(239, 355);
            this.lbPatients.TabIndex = 27;
            this.lbPatients.SelectedIndexChanged += new System.EventHandler(this.LbPatients_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Krankenkasse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Krankenversichertennummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Geburtsdatum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Hausarzt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Adresse";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Geschlecht";
            // 
            // lblInsuranceAgency
            // 
            this.lblInsuranceAgency.AutoSize = true;
            this.lblInsuranceAgency.Location = new System.Drawing.Point(303, 36);
            this.lblInsuranceAgency.Name = "lblInsuranceAgency";
            this.lblInsuranceAgency.Size = new System.Drawing.Size(10, 13);
            this.lblInsuranceAgency.TabIndex = 35;
            this.lblInsuranceAgency.Text = "-";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(303, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(10, 13);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "-";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(303, 132);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(10, 13);
            this.lblGender.TabIndex = 37;
            this.lblGender.Text = "-";
            // 
            // lblLocalDoctor
            // 
            this.lblLocalDoctor.AutoSize = true;
            this.lblLocalDoctor.Location = new System.Drawing.Point(303, 181);
            this.lblLocalDoctor.Name = "lblLocalDoctor";
            this.lblLocalDoctor.Size = new System.Drawing.Size(10, 13);
            this.lblLocalDoctor.TabIndex = 38;
            this.lblLocalDoctor.Text = "-";
            // 
            // lblInsuranceNr
            // 
            this.lblInsuranceNr.AutoSize = true;
            this.lblInsuranceNr.Location = new System.Drawing.Point(552, 36);
            this.lblInsuranceNr.Name = "lblInsuranceNr";
            this.lblInsuranceNr.Size = new System.Drawing.Size(10, 13);
            this.lblInsuranceNr.TabIndex = 39;
            this.lblInsuranceNr.Text = "-";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(552, 84);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(10, 13);
            this.lblBirthday.TabIndex = 40;
            this.lblBirthday.Text = "-";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(552, 132);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(10, 13);
            this.lblAddress.TabIndex = 41;
            this.lblAddress.Text = "-";
            // 
            // lblTelNr
            // 
            this.lblTelNr.AutoSize = true;
            this.lblTelNr.Location = new System.Drawing.Point(303, 230);
            this.lblTelNr.Name = "lblTelNr";
            this.lblTelNr.Size = new System.Drawing.Size(10, 13);
            this.lblTelNr.TabIndex = 43;
            this.lblTelNr.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Telefonnummer";
            // 
            // lbTreatments
            // 
            this.lbTreatments.FormattingEnabled = true;
            this.lbTreatments.Location = new System.Drawing.Point(273, 288);
            this.lbTreatments.Name = "lbTreatments";
            this.lbTreatments.Size = new System.Drawing.Size(100, 108);
            this.lbTreatments.TabIndex = 44;
            this.lbTreatments.SelectedIndexChanged += new System.EventHandler(this.LbTreatment_SelectedIndexChanged);
            // 
            // tbEntry
            // 
            this.tbEntry.Location = new System.Drawing.Point(380, 288);
            this.tbEntry.Multiline = true;
            this.tbEntry.Name = "tbEntry";
            this.tbEntry.ReadOnly = true;
            this.tbEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEntry.Size = new System.Drawing.Size(257, 108);
            this.tbEntry.TabIndex = 45;
            // 
            // tbMedication
            // 
            this.tbMedication.Location = new System.Drawing.Point(643, 288);
            this.tbMedication.Multiline = true;
            this.tbMedication.Name = "tbMedication";
            this.tbMedication.ReadOnly = true;
            this.tbMedication.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMedication.Size = new System.Drawing.Size(130, 108);
            this.tbMedication.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Behandlungsdatum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Eintrag";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(640, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Medikation";
            // 
            // FrmAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 446);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMedication);
            this.Controls.Add(this.tbEntry);
            this.Controls.Add(this.lbTreatments);
            this.Controls.Add(this.lblTelNr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblInsuranceNr);
            this.Controls.Add(this.lblLocalDoctor);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInsuranceAgency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPatients);
            this.Controls.Add(this.bttn_newEntry);
            this.Controls.Add(this.bttn_editEntry);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_editPatient);
            this.Controls.Add(this.bttn_newPatient);
            this.Name = "FrmAdministration";
            this.Text = "Patientenverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_newPatient;
        private System.Windows.Forms.Button bttn_editPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button bttn_editEntry;
        private System.Windows.Forms.Button bttn_newEntry;
        private System.Windows.Forms.ListBox lbPatients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblInsuranceAgency;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLocalDoctor;
        private System.Windows.Forms.Label lblInsuranceNr;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTelNr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbTreatments;
        private System.Windows.Forms.TextBox tbEntry;
        private System.Windows.Forms.TextBox tbMedication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

