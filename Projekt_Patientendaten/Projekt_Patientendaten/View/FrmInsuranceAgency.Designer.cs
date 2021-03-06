﻿namespace Projekt_Patientendaten.View
{
    partial class FrmInsuranceAgency
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
            this.BtnEditAddress = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.GroupBox();
            this.tb_country = new System.Windows.Forms.Label();
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
            this.btnSave.Location = new System.Drawing.Point(113, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(247, 20);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(113, 122);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(247, 64);
            this.tbNote.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Notiz:";
            // 
            // BtnEditAddress
            // 
            this.BtnEditAddress.Location = new System.Drawing.Point(282, 66);
            this.BtnEditAddress.Name = "BtnEditAddress";
            this.BtnEditAddress.Size = new System.Drawing.Size(66, 21);
            this.BtnEditAddress.TabIndex = 42;
            this.BtnEditAddress.Text = "Bearbeiten";
            this.BtnEditAddress.UseVisualStyleBackColor = true;
            this.BtnEditAddress.Click += new System.EventHandler(this.BtnEditAddress_Click);
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
            this.addressBox.Size = new System.Drawing.Size(354, 94);
            this.addressBox.TabIndex = 44;
            this.addressBox.TabStop = false;
            this.addressBox.Text = "Adressdaten";
            // 
            // tb_country
            // 
            this.tb_country.AutoSize = true;
            this.tb_country.Location = new System.Drawing.Point(99, 57);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(57, 13);
            this.tb_country.TabIndex = 39;
            this.tb_country.Text = "- Adresse -";
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
            this.tb_telNr.Location = new System.Drawing.Point(99, 70);
            this.tb_telNr.Name = "tb_telNr";
            this.tb_telNr.Size = new System.Drawing.Size(92, 13);
            this.tb_telNr.TabIndex = 40;
            this.tb_telNr.Text = "- Telefonnummer -";
            // 
            // tb_name
            // 
            this.tb_name.AutoSize = true;
            this.tb_name.Location = new System.Drawing.Point(99, 18);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(47, 13);
            this.tb_name.TabIndex = 36;
            this.tb_name.Text = "- Name -";
            // 
            // tb_streetAndHouseNr
            // 
            this.tb_streetAndHouseNr.AutoSize = true;
            this.tb_streetAndHouseNr.Location = new System.Drawing.Point(99, 31);
            this.tb_streetAndHouseNr.Name = "tb_streetAndHouseNr";
            this.tb_streetAndHouseNr.Size = new System.Drawing.Size(57, 13);
            this.tb_streetAndHouseNr.TabIndex = 37;
            this.tb_streetAndHouseNr.Text = "- Adresse -";
            // 
            // tb_plzAndVillage
            // 
            this.tb_plzAndVillage.AutoSize = true;
            this.tb_plzAndVillage.Location = new System.Drawing.Point(99, 44);
            this.tb_plzAndVillage.Name = "tb_plzAndVillage";
            this.tb_plzAndVillage.Size = new System.Drawing.Size(57, 13);
            this.tb_plzAndVillage.TabIndex = 38;
            this.tb_plzAndVillage.Text = "- Adresse -";
            // 
            // FrmInsuranceAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 224);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label6);
            this.Name = "FrmInsuranceAgency";
            this.Text = "Krankenversicherung";
            this.addressBox.ResumeLayout(false);
            this.addressBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEditAddress;
        private System.Windows.Forms.GroupBox addressBox;
        private System.Windows.Forms.Label tb_country;
        private System.Windows.Forms.Label lblTelNr;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label tb_telNr;
        private System.Windows.Forms.Label tb_name;
        private System.Windows.Forms.Label tb_streetAndHouseNr;
        private System.Windows.Forms.Label tb_plzAndVillage;
    }
}