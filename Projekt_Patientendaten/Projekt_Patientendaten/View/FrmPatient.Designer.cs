namespace Projekt_Patientendaten.View
{
    partial class FrmPatient
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.lblSubjectArea = new System.Windows.Forms.Label();
            this.tbInsuranceNr = new System.Windows.Forms.TextBox();
            this.lblInsuranceNr = new System.Windows.Forms.Label();
            this.cbInsurance = new System.Windows.Forms.ComboBox();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.BtnEditInsurance = new System.Windows.Forms.Button();
            this.BtnAddInsurance = new System.Windows.Forms.Button();
            this.BtnEditDoctor = new System.Windows.Forms.Button();
            this.BtnAddDoctor = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.GroupBox();
            this.tb_country = new System.Windows.Forms.Label();
            this.BtnEditAddress = new System.Windows.Forms.Button();
            this.lblTelNr = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tb_telNr = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.Label();
            this.tb_streetAndHouseNr = new System.Windows.Forms.Label();
            this.tb_plzAndVillage = new System.Windows.Forms.Label();
            this.addressBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 20);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(173, 267);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(244, 64);
            this.tbNote.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Notiz:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(173, 124);
            this.dtpBirthday.MaxDate = new System.DateTime(2020, 3, 8, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(244, 20);
            this.dtpBirthday.TabIndex = 38;
            this.dtpBirthday.Value = new System.DateTime(2020, 3, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Geburtsdatum:";
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(173, 150);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(244, 20);
            this.tbGender.TabIndex = 41;
            // 
            // lblSubjectArea
            // 
            this.lblSubjectArea.Location = new System.Drawing.Point(21, 150);
            this.lblSubjectArea.Name = "lblSubjectArea";
            this.lblSubjectArea.Size = new System.Drawing.Size(116, 20);
            this.lblSubjectArea.TabIndex = 40;
            this.lblSubjectArea.Text = "Geschlecht:";
            // 
            // tbInsuranceNr
            // 
            this.tbInsuranceNr.Location = new System.Drawing.Point(173, 176);
            this.tbInsuranceNr.Name = "tbInsuranceNr";
            this.tbInsuranceNr.Size = new System.Drawing.Size(244, 20);
            this.tbInsuranceNr.TabIndex = 43;
            // 
            // lblInsuranceNr
            // 
            this.lblInsuranceNr.Location = new System.Drawing.Point(21, 176);
            this.lblInsuranceNr.Name = "lblInsuranceNr";
            this.lblInsuranceNr.Size = new System.Drawing.Size(146, 20);
            this.lblInsuranceNr.TabIndex = 42;
            this.lblInsuranceNr.Text = "Krankenversichertenummer:";
            // 
            // cbInsurance
            // 
            this.cbInsurance.FormattingEnabled = true;
            this.cbInsurance.Location = new System.Drawing.Point(173, 202);
            this.cbInsurance.Name = "cbInsurance";
            this.cbInsurance.Size = new System.Drawing.Size(193, 21);
            this.cbInsurance.TabIndex = 45;
            this.cbInsurance.SelectedIndexChanged += new System.EventHandler(this.CbInsurance_SelectedIndexChanged);
            // 
            // lblInsurance
            // 
            this.lblInsurance.Location = new System.Drawing.Point(21, 203);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(116, 20);
            this.lblInsurance.TabIndex = 44;
            this.lblInsurance.Text = "Krankenkasse:";
            // 
            // cbDoctor
            // 
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(173, 229);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(193, 21);
            this.cbDoctor.TabIndex = 47;
            this.cbDoctor.SelectedIndexChanged += new System.EventHandler(this.CbDoctor_SelectedIndexChanged);
            // 
            // lblDoctor
            // 
            this.lblDoctor.Location = new System.Drawing.Point(21, 230);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(116, 20);
            this.lblDoctor.TabIndex = 46;
            this.lblDoctor.Text = "Hausarzt:";
            // 
            // BtnEditInsurance
            // 
            this.BtnEditInsurance.Location = new System.Drawing.Point(396, 201);
            this.BtnEditInsurance.Name = "BtnEditInsurance";
            this.BtnEditInsurance.Size = new System.Drawing.Size(21, 21);
            this.BtnEditInsurance.TabIndex = 51;
            this.BtnEditInsurance.Text = "*";
            this.BtnEditInsurance.UseVisualStyleBackColor = true;
            this.BtnEditInsurance.Click += new System.EventHandler(this.BtnEditInsurance_Click);
            // 
            // BtnAddInsurance
            // 
            this.BtnAddInsurance.Location = new System.Drawing.Point(372, 201);
            this.BtnAddInsurance.Name = "BtnAddInsurance";
            this.BtnAddInsurance.Size = new System.Drawing.Size(21, 21);
            this.BtnAddInsurance.TabIndex = 50;
            this.BtnAddInsurance.Text = "+";
            this.BtnAddInsurance.UseVisualStyleBackColor = true;
            this.BtnAddInsurance.Click += new System.EventHandler(this.BtnAddInsurance_Click);
            // 
            // BtnEditDoctor
            // 
            this.BtnEditDoctor.Location = new System.Drawing.Point(396, 228);
            this.BtnEditDoctor.Name = "BtnEditDoctor";
            this.BtnEditDoctor.Size = new System.Drawing.Size(21, 21);
            this.BtnEditDoctor.TabIndex = 53;
            this.BtnEditDoctor.Text = "*";
            this.BtnEditDoctor.UseVisualStyleBackColor = true;
            this.BtnEditDoctor.Click += new System.EventHandler(this.BtnEditDoctor_Click);
            // 
            // BtnAddDoctor
            // 
            this.BtnAddDoctor.Location = new System.Drawing.Point(372, 228);
            this.BtnAddDoctor.Name = "BtnAddDoctor";
            this.BtnAddDoctor.Size = new System.Drawing.Size(21, 21);
            this.BtnAddDoctor.TabIndex = 52;
            this.BtnAddDoctor.Text = "+";
            this.BtnAddDoctor.UseVisualStyleBackColor = true;
            this.BtnAddDoctor.Click += new System.EventHandler(this.BtnAddDoctor_Click);
            // 
            // addressBox
            // 
            this.addressBox.Controls.Add(this.tb_country);
            this.addressBox.Controls.Add(this.BtnEditAddress);
            this.addressBox.Controls.Add(this.lblTelNr);
            this.addressBox.Controls.Add(this.lblAddress);
            this.addressBox.Controls.Add(this.lblName);
            this.addressBox.Controls.Add(this.tb_telNr);
            this.addressBox.Controls.Add(this.tb_name);
            this.addressBox.Controls.Add(this.tb_streetAndHouseNr);
            this.addressBox.Controls.Add(this.tb_plzAndVillage);
            this.addressBox.Location = new System.Drawing.Point(12, 12);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(420, 94);
            this.addressBox.TabIndex = 54;
            this.addressBox.TabStop = false;
            this.addressBox.Text = "Adressdaten";
            // 
            // tb_country
            // 
            this.tb_country.AutoSize = true;
            this.tb_country.Location = new System.Drawing.Point(158, 57);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(57, 13);
            this.tb_country.TabIndex = 39;
            this.tb_country.Text = "- Adresse -";
            // 
            // BtnEditAddress
            // 
            this.BtnEditAddress.Location = new System.Drawing.Point(339, 66);
            this.BtnEditAddress.Name = "BtnEditAddress";
            this.BtnEditAddress.Size = new System.Drawing.Size(66, 21);
            this.BtnEditAddress.TabIndex = 42;
            this.BtnEditAddress.Text = "Bearbeiten";
            this.BtnEditAddress.UseVisualStyleBackColor = true;
            this.BtnEditAddress.Click += new System.EventHandler(this.BtnEditAddress_Click);
            // 
            // lblTelNr
            // 
            this.lblTelNr.Location = new System.Drawing.Point(9, 70);
            this.lblTelNr.Name = "lblTelNr";
            this.lblTelNr.Size = new System.Drawing.Size(87, 13);
            this.lblTelNr.TabIndex = 42;
            this.lblTelNr.Text = "Telefonnummer:";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(9, 31);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 13);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Adresse:";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(9, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "Name:";
            // 
            // tb_telNr
            // 
            this.tb_telNr.AutoSize = true;
            this.tb_telNr.Location = new System.Drawing.Point(158, 70);
            this.tb_telNr.Name = "tb_telNr";
            this.tb_telNr.Size = new System.Drawing.Size(92, 13);
            this.tb_telNr.TabIndex = 40;
            this.tb_telNr.Text = "- Telefonnummer -";
            // 
            // tb_name
            // 
            this.tb_name.AutoSize = true;
            this.tb_name.Location = new System.Drawing.Point(158, 18);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(47, 13);
            this.tb_name.TabIndex = 36;
            this.tb_name.Text = "- Name -";
            // 
            // tb_streetAndHouseNr
            // 
            this.tb_streetAndHouseNr.AutoSize = true;
            this.tb_streetAndHouseNr.Location = new System.Drawing.Point(158, 31);
            this.tb_streetAndHouseNr.Name = "tb_streetAndHouseNr";
            this.tb_streetAndHouseNr.Size = new System.Drawing.Size(57, 13);
            this.tb_streetAndHouseNr.TabIndex = 37;
            this.tb_streetAndHouseNr.Text = "- Adresse -";
            // 
            // tb_plzAndVillage
            // 
            this.tb_plzAndVillage.AutoSize = true;
            this.tb_plzAndVillage.Location = new System.Drawing.Point(158, 44);
            this.tb_plzAndVillage.Name = "tb_plzAndVillage";
            this.tb_plzAndVillage.Size = new System.Drawing.Size(57, 13);
            this.tb_plzAndVillage.TabIndex = 38;
            this.tb_plzAndVillage.Text = "- Adresse -";
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 369);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.BtnEditDoctor);
            this.Controls.Add(this.BtnAddDoctor);
            this.Controls.Add(this.BtnEditInsurance);
            this.Controls.Add(this.BtnAddInsurance);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.cbInsurance);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.tbInsuranceNr);
            this.Controls.Add(this.lblInsuranceNr);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.lblSubjectArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label6);
            this.Name = "FrmPatient";
            this.Text = "Patient";
            this.addressBox.ResumeLayout(false);
            this.addressBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label lblSubjectArea;
        private System.Windows.Forms.TextBox tbInsuranceNr;
        private System.Windows.Forms.Label lblInsuranceNr;
        private System.Windows.Forms.ComboBox cbInsurance;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Button BtnEditInsurance;
        private System.Windows.Forms.Button BtnAddInsurance;
        private System.Windows.Forms.Button BtnEditDoctor;
        private System.Windows.Forms.Button BtnAddDoctor;
        private System.Windows.Forms.GroupBox addressBox;
        private System.Windows.Forms.Label tb_country;
        private System.Windows.Forms.Button BtnEditAddress;
        private System.Windows.Forms.Label lblTelNr;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label tb_telNr;
        private System.Windows.Forms.Label tb_name;
        private System.Windows.Forms.Label tb_streetAndHouseNr;
        private System.Windows.Forms.Label tb_plzAndVillage;
    }
}