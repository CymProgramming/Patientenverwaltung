using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Patientendaten.View
{
    public partial class FrmPatient : Form
    {
        public Model.Patient patient;

        private Model.Address selectedAddress;
        private Model.InsuranceAgency selectedInsurance;
        private Model.Doctor selectedDoctor;

        private List<Model.InsuranceAgency> insuranceAgencies;
        private List<Model.Doctor> doctors;

        public FrmPatient()
        {
            InitializeComponent();
            InitializeAdditionalComponents();
        }

        public FrmPatient(Model.Patient editPatient)
        {
            InitializeComponent();
            InitializeAdditionalComponents();

            patient = editPatient;
            selectedAddress = editPatient.Address;
            selectedInsurance = editPatient.InsuranceAgency;
            selectedDoctor = editPatient.LocalDoctor;

            tbGender.Text = editPatient.Gender;
            dtpBirthday.Value = editPatient.Birthday;
            tbInsuranceNr.Text = Convert.ToString(editPatient.InsuranceNr);
            tbNote.Text = editPatient.Note;

            InitializeAddresses();
            cbInsurance.SelectedIndex = insuranceAgencies.Select(o => o.Id).ToList().IndexOf(selectedInsurance.Id);
            cbDoctor.SelectedIndex = doctors.Select(o => o.Id).ToList().IndexOf(selectedDoctor.Id);

            InitializeAddresses();
        }

        private void InitializeAdditionalComponents()
        {
            InitializeInsuranceAgencies();
            InitializeDoctors();
        }

        private void InitializeAddresses()
        {
            tb_name.Text = selectedAddress.Name;
            tb_streetAndHouseNr.Text = selectedAddress.Street + " " + selectedAddress.HouseNr;
            tb_plzAndVillage.Text = selectedAddress.Plz + " " + selectedAddress.Village;
            tb_country.Text = selectedAddress.Country;
            tb_telNr.Text = selectedAddress.TelNr;
        }

        private void InitializeInsuranceAgencies()
        {
            cbInsurance.Items.Clear();
            insuranceAgencies = Model.Databasemanager.GetInsuranceAgencies();

            foreach (var agency in insuranceAgencies)
            {
                cbInsurance.Items.Add(agency.Name);
            }
        }

        private void InitializeDoctors()
        {
            cbDoctor.Items.Clear();
            doctors = Model.Databasemanager.GetDoctors();

            foreach (var doctor in doctors)
            {
                cbDoctor.Items.Add(doctor.Name);
            }
        }

        private void CbInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInsurance = insuranceAgencies[cbInsurance.SelectedIndex];
        }

        private void CbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedDoctor = doctors[cbDoctor.SelectedIndex];
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            const string argumentNullError = "Der Patient kann nicht gespeichert werden ohne ";
            const string strBirthday = "ein gültiges Geburtsdatum.";
            const string strGender = "ein Geschlecht.";
            const string strAddress = "gültige Adressdaten.";
            const string strInsurance = "eine Krankenkasse.";
            const string strDoctor = "einen Hausarzt.";

            if (dtpBirthday.Text == String.Empty)
            {
                MessageBox.Show(argumentNullError + strBirthday);
            }
            else if (tbGender.Text == String.Empty)
            {
                MessageBox.Show(argumentNullError + strGender);
            }
            else if (selectedAddress == null)
            {
                MessageBox.Show(argumentNullError + strAddress);
            }
            else if (selectedInsurance == null)
            {
                MessageBox.Show(argumentNullError + strInsurance);
            }
            else if (selectedDoctor == null)
            {
                MessageBox.Show(argumentNullError + strDoctor);
            }
            else
            {
                if (int.TryParse(tbInsuranceNr.Text, out var insuranceNr))
                {
                    var birthday = dtpBirthday.Value;
                    var gender = tbGender.Text;
                    var note = tbNote.Text;

                    if (patient != null) // edit handover patient
                    {
                        patient.Birthday = birthday;
                        patient.Gender = gender;
                        patient.InsuranceNr = insuranceNr;
                        patient.InsuranceAgency = selectedInsurance;
                        patient.LocalDoctor = selectedDoctor;
                        patient.Address = selectedAddress;
                        patient.Note = tbNote.Text;
                        patient.Update();
                    }
                    else
                    {
                        patient = new Model.Patient(birthday, gender, selectedInsurance, insuranceNr, selectedDoctor, selectedAddress, note); // create new patient
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Die Krankenversichertennummer darf nur aus Ziffern bestehen."); //TODO: Maybe not use Integer in the Database? My InsuranceID has letters in it
                }
            }
        }

        private void BtnEditAddress_Click(object sender, EventArgs e)
        {
            if (selectedAddress == null)
            {
                using (var formAddress = new FrmAddress())
                {
                    var result = formAddress.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        selectedAddress = formAddress.Address;

                        InitializeAddresses();
                    }
                }
            }
            else
            {
                using (var formAddress = new FrmAddress(selectedAddress))
                {
                    var result = formAddress.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        selectedAddress = formAddress.Address;

                        InitializeAddresses();
                    }
                }
            }
        }

        private void BtnAddInsurance_Click(object sender, EventArgs e)
        {
            using (var formInsurance = new FrmInsuranceAgency())
            {
                var result = formInsurance.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var insuranceAgency = formInsurance.insuranceAgency;

                    InitializeInsuranceAgencies();

                    selectedInsurance = insuranceAgency;
                    cbInsurance.SelectedIndex = insuranceAgencies.Select(o => o.Id).ToList().IndexOf(selectedInsurance.Id);
                }
            }
        }

        private void BtnEditInsurance_Click(object sender, EventArgs e)
        {
            if (selectedInsurance == null)
            {
                MessageBox.Show("Um eine bestehende Krankenkasse zu bearbeiten, muss zunächst eine Krankenkasse ausgewählt werden.");
            }
            else
            {
                using (var formInsurance = new FrmInsuranceAgency(selectedInsurance))
                {
                    var result = formInsurance.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        var insuranceAgency = formInsurance.insuranceAgency;

                        InitializeInsuranceAgencies();

                        selectedInsurance = insuranceAgency;
                        cbInsurance.SelectedIndex = insuranceAgencies.Select(o => o.Id).ToList().IndexOf(selectedInsurance.Id);
                    }
                }
            }
        }

        private void BtnAddDoctor_Click(object sender, EventArgs e)
        {
            using (var formDoctor = new FrmDoctor())
            {
                var result = formDoctor.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var doctor = formDoctor.doctor;

                    InitializeDoctors();

                    selectedDoctor = doctor;
                    cbDoctor.SelectedIndex = doctors.Select(o => o.Id).ToList().IndexOf(selectedDoctor.Id);
                }
            }
        }

        private void BtnEditDoctor_Click(object sender, EventArgs e)
        {
            if (selectedDoctor == null)
            {
                MessageBox.Show("Um einen bestehenden Arzt zu bearbeiten, muss zunächst ein Arzt ausgewählt werden.");
            }
            else
            {
                using (var formDoctor = new FrmDoctor(selectedDoctor))
                {
                    var result = formDoctor.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        var doctor = formDoctor.doctor;

                        InitializeDoctors();

                        selectedDoctor = doctor;
                        cbDoctor.SelectedIndex = doctors.Select(o => o.Id).ToList().IndexOf(selectedDoctor.Id);
                    }
                }
            }
        }
    }
}
