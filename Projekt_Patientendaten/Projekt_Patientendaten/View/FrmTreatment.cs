using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projekt_Patientendaten.Model;

namespace Projekt_Patientendaten
{
    public partial class FrmTreatment : Form
    {
        private Model.Patient SelectedPatient { get; set; }
        private List<Patient> Patients { get; set; }
        
        private Model.Treatment Treatment { get; set; }

        public FrmTreatment(List<Model.Patient> patientList) // create new treatment
        {
            InitializeComponent();
            foreach (var patient in patientList)
            {
                cbPatient.Items.Add(patient.Name);
            }

            Patients = patientList;
        }

        public FrmTreatment(List<Model.Patient> patientList, Model.Treatment treatment) // edit handover treatment
        {
            InitializeComponent();
            
            Patients = patientList;
            Treatment = treatment;
            
            foreach (var patient in patientList)
            {
                if (patient.Id == treatment.PatientId)
                {
                    SelectedPatient = patient;
                    break;
                }
            }

            cbPatient.Items.Add(SelectedPatient.Name);
            cbPatient.SelectedIndex = 0;
            cbPatient.Enabled = false;
            
            tbEntry.Text = treatment.Entry;
            tbMedication.Text = treatment.Medication;
            lblDate.Text = treatment.Date.ToString("dd.MM.yyyy");
            tbNote.Text = treatment.Note;
            
            tbEntry.Enabled = true;
            tbMedication.Enabled = true;
            tbNote.Enabled = true;
            btnSave.Enabled = true;
        }


        private void cbPatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedPatient = Patients[cbPatient.SelectedIndex];
            lblDate.Text = Convert.ToString(DateTime.Now.Date);
            tbEntry.Enabled = true;
            tbMedication.Enabled = true;
            tbNote.Enabled = true;
            btnSave.Enabled = true;
        }

        
        private void FrmTreatment_Load(object sender, EventArgs e)
        {
            if (Treatment != null)
            {
                lblDate.Text = Treatment.Date.ToString("dd.MM.yyyy");
            } else
            {
                lblDate.Text = Convert.ToString(DateTime.Now.Date);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var note = tbNote.Text;
            var medication = tbMedication.Text;
            var entry = tbEntry.Text;

            if (entry != String.Empty)
            {
                if (Treatment != null) // edit handover Treatment
                {
                    Treatment.Note = tbNote.Text;
                    Treatment.Medication = tbMedication.Text;
                    Treatment.Entry = tbEntry.Text;
                    Treatment.Update();
                    this.DialogResult = DialogResult.OK;
                }
                else // save new Treatment
                {
                    var treatment = new Model.Treatment(SelectedPatient.Id, DateTime.Now, entry, medication, note);
                    SelectedPatient.Treatments.Add(treatment);
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Um die Behandlung zu speichern, muss ein Eintrag getätigt werden.");
            }
        }
    }
}