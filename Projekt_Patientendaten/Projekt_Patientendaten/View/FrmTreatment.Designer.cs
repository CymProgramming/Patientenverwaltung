using System.ComponentModel;

namespace Projekt_Patientendaten
{
    partial class FrmTreatment
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
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblMedication = new System.Windows.Forms.Label();
            this.cbPatient = new System.Windows.Forms.ComboBox();
            this.tbMedication = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbEntry = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatient
            // 
            this.lblPatient.Location = new System.Drawing.Point(10, 13);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(86, 20);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "Patient:";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(76, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "- Date - ";
            // 
            // lblEntry
            // 
            this.lblEntry.Location = new System.Drawing.Point(10, 137);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(86, 20);
            this.lblEntry.TabIndex = 2;
            this.lblEntry.Text = "Eintrag:";
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(10, 94);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(86, 20);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Notiz: ";
            // 
            // lblMedication
            // 
            this.lblMedication.Location = new System.Drawing.Point(10, 63);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(86, 20);
            this.lblMedication.TabIndex = 4;
            this.lblMedication.Text = "Medikation:";
            // 
            // cbPatient
            // 
            this.cbPatient.FormattingEnabled = true;
            this.cbPatient.Location = new System.Drawing.Point(76, 10);
            this.cbPatient.Name = "cbPatient";
            this.cbPatient.Size = new System.Drawing.Size(297, 21);
            this.cbPatient.TabIndex = 5;
            this.cbPatient.SelectionChangeCommitted += new System.EventHandler(this.cbPatient_SelectionChangeCommitted);
            // 
            // tbMedication
            // 
            this.tbMedication.Enabled = false;
            this.tbMedication.Location = new System.Drawing.Point(76, 61);
            this.tbMedication.Name = "tbMedication";
            this.tbMedication.Size = new System.Drawing.Size(298, 20);
            this.tbMedication.TabIndex = 6;
            // 
            // tbNote
            // 
            this.tbNote.Enabled = false;
            this.tbNote.Location = new System.Drawing.Point(76, 91);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(298, 20);
            this.tbNote.TabIndex = 7;
            // 
            // tbEntry
            // 
            this.tbEntry.Enabled = false;
            this.tbEntry.Location = new System.Drawing.Point(76, 137);
            this.tbEntry.Multiline = true;
            this.tbEntry.Name = "tbEntry";
            this.tbEntry.Size = new System.Drawing.Size(298, 150);
            this.tbEntry.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(76, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(297, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Datum: ";
            // 
            // FrmTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbEntry);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbMedication);
            this.Controls.Add(this.cbPatient);
            this.Controls.Add(this.lblMedication);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPatient);
            this.Name = "FrmTreatment";
            this.Text = "Behandlung";
            this.Load += new System.EventHandler(this.FrmTreatment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox tbEntry;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbMedication;
        private System.Windows.Forms.ComboBox cbPatient;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}