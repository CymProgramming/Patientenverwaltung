using System.ComponentModel;

namespace Projekt_Patientendaten
{
    partial class FrmAddress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlz = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPlz = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbVillage = new System.Windows.Forms.TextBox();
            this.tbHouseNr = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbTelNr = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(10, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPlz
            // 
            this.lblPlz.Location = new System.Drawing.Point(10, 90);
            this.lblPlz.Name = "lblPlz";
            this.lblPlz.Size = new System.Drawing.Size(86, 20);
            this.lblPlz.TabIndex = 1;
            this.lblPlz.Text = "Postleitzahl:";
            // 
            // lblStreet
            // 
            this.lblStreet.Location = new System.Drawing.Point(10, 38);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(86, 20);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Straße:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stadt:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hausnummer:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Notiz:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Land:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefonnummer:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(102, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(171, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbPlz
            // 
            this.tbPlz.Location = new System.Drawing.Point(102, 88);
            this.tbPlz.Name = "tbPlz";
            this.tbPlz.Size = new System.Drawing.Size(171, 20);
            this.tbPlz.TabIndex = 11;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(102, 36);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(171, 20);
            this.tbStreet.TabIndex = 9;
            // 
            // tbVillage
            // 
            this.tbVillage.Location = new System.Drawing.Point(102, 114);
            this.tbVillage.Name = "tbVillage";
            this.tbVillage.Size = new System.Drawing.Size(171, 20);
            this.tbVillage.TabIndex = 12;
            // 
            // tbHouseNr
            // 
            this.tbHouseNr.Location = new System.Drawing.Point(102, 62);
            this.tbHouseNr.Name = "tbHouseNr";
            this.tbHouseNr.Size = new System.Drawing.Size(171, 20);
            this.tbHouseNr.TabIndex = 10;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(102, 140);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(171, 20);
            this.tbCountry.TabIndex = 13;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(102, 191);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(171, 62);
            this.tbNote.TabIndex = 15;
            // 
            // tbTelNr
            // 
            this.tbTelNr.Location = new System.Drawing.Point(102, 165);
            this.tbTelNr.Name = "tbTelNr";
            this.tbTelNr.Size = new System.Drawing.Size(171, 20);
            this.tbTelNr.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 20);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 287);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTelNr);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbHouseNr);
            this.Controls.Add(this.tbVillage);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbPlz);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblPlz);
            this.Controls.Add(this.lblName);
            this.Name = "FrmAddress";
            this.Text = "Adresse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlz;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPlz;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbVillage;
        private System.Windows.Forms.TextBox tbHouseNr;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbTelNr;
    }
}