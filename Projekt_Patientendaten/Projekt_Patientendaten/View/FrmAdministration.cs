using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Projekt_Patientendaten.Model;

namespace Projekt_Patientendaten
{
    public partial class FrmAdministration : Form
    {
        private List<Patient> allPatients;
        private List<Patient> activePatients;

        private List<Treatment> treatments;

        private Patient selectedPatient;
        private Treatment selectedTreatment;


        public FrmAdministration()
        {
            InitializeComponent();

            InitializePatients();
        }

        private void InitializePatients()
        {
            allPatients = Databasemanager.GetPatients().OrderBy(o => o.Name).ToList();
            activePatients = allPatients;

            fillPatientList(activePatients);
        }

        private void fillPatientList(List<Patient> patients)
        {
            lbPatients.Items.Clear();

            foreach (var patient in patients)
            {
                lbPatients.Items.Add(patient.Name);
            }
        }

        private void fillTreatmentList(List<Treatment> treaments)
        {
            lbTreatments.Items.Clear();

            foreach (var treatment in treatments)
            {
                lbTreatments.Items.Add(treatment.Date.ToString("dd.MM.yyyy"));
            }
        }

        private void fillPatient(Patient patient)
        {
            clearPatient();

            lblName.Text = patient.Name;
            lblBirthday.Text = patient.Birthday.ToString("dd.MM.yyyy");
            lblGender.Text = patient.Gender;
            lblAddress.Text = patient.Address.Plz + " " + patient.Address.Village + "\r\n" +
                    patient.Address.Street + " " + patient.Address.HouseNr + "\r\n" +
                    patient.Address.Country;
            lblTelNr.Text = patient.Address.TelNr;
            lblInsuranceAgency.Text = patient.InsuranceAgency.Name;
            lblLocalDoctor.Text = patient.LocalDoctor.Name;
            lblInsuranceNr.Text = Convert.ToString(patient.InsuranceNr);
        }

        private void clearPatient()
        {
            lblInsuranceAgency.Text = "-";
            lblInsuranceNr.Text = "-";
            lblName.Text = "-";
            lblBirthday.Text = "-";
            lblGender.Text = "-";
            lblLocalDoctor.Text = "-";
            lblAddress.Text = "-";
            lblTelNr.Text = "-";

            tbEntry.Text = "";
            tbMedication.Text = "";
            lbTreatments.Items.Clear();
        }

        private void bttn_newPatient_Click(object sender, EventArgs e)
        {
            using (var formPatient = new View.FrmPatient())
            {
                var result = formPatient.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var patient = formPatient.patient;

                    InitializePatients();

                    selectedPatient = patient;
                    lbPatients.SelectedIndex = activePatients.Select(o => o.Id).ToList().IndexOf(selectedPatient.Id);
                }
            }
        }

        private void bttn_editPatient_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                using (var formPatient = new View.FrmPatient(selectedPatient))
                {
                    var result = formPatient.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        var patient = formPatient.patient;

                        InitializePatients();

                        selectedPatient = patient;
                        lbPatients.SelectedIndex = activePatients.Select(o => o.Id).ToList().IndexOf(selectedPatient.Id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Um die Patientendaten eines bestehenden Patienten zu bearbeiten, müssen sie zunächst einen Patienten auswählen.");
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string search = tb_search.Text;

            if (search == "")
            {
                activePatients = allPatients;
                fillPatientList(activePatients);
            }
            else
            {
                List<Patient> newActivePatients = new List<Patient>();

                foreach (var patient in allPatients)
                {
                    if (patient.Name.Contains(search)) newActivePatients.Add(patient);
                    else if (patient.Address.Village.Contains(search)) newActivePatients.Add(patient);
                    else if (patient.Address.Street.Contains(search)) newActivePatients.Add(patient);
                    else if (patient.Address.Country.Contains(search)) newActivePatients.Add(patient);
                }

                activePatients = newActivePatients;
                fillPatientList(activePatients);
            }
        }

        private void bttn_newEntry_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                List<Patient> choices = new List<Patient>(); // So the user doesn't need to look through a long dropdown
                choices.Add(selectedPatient);

                using (var formTreatment = new FrmTreatment(choices))
                {
                    var result = formTreatment.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        treatments = Databasemanager.GetTreatments(selectedPatient.Id);
                        fillTreatmentList(treatments);
                    }
                }
            }
            else
            {
                using (var formTreatment = new FrmTreatment(allPatients))
                {
                    var result = formTreatment.ShowDialog();
                }
            }
        }

        private void bttn_editEntry_Click(object sender, EventArgs e)
        {
            if (selectedTreatment != null)
            {
                List<Patient> choices = new List<Patient>(); // So the user doesn't need to look through a long dropdown
                choices.Add(selectedPatient);

                using (var formTreatment = new FrmTreatment(choices, selectedTreatment))
                {
                    var result = formTreatment.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        treatments = Databasemanager.GetTreatments(selectedPatient.Id);
                        fillTreatmentList(treatments);
                    }
                }
            }
            else
            {
                MessageBox.Show("Um die Behandlungsdaten einer bestehenden Behandlung zu bearbeiten, müssen sie zunächst eine Behandlung auswählen.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPatients.SelectedIndex >= 0 && lbPatients.SelectedIndex < activePatients.Count)
            {
                selectedPatient = activePatients[lbPatients.SelectedIndex];
                treatments = Databasemanager.GetTreatments(selectedPatient.Id);

                fillPatient(selectedPatient);
                fillTreatmentList(treatments);
            }
        }

        private void LbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTreatments.SelectedIndex >= 0 && lbTreatments.SelectedIndex < treatments.Count)
            {
                selectedTreatment = treatments[lbTreatments.SelectedIndex];

                tbEntry.Text = selectedTreatment.Entry;
                tbMedication.Text = selectedTreatment.Medication;
            }
        }
    }
}