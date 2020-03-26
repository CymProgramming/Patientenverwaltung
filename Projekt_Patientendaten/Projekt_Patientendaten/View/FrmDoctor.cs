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
    public partial class FrmDoctor : Form
    {
        public Model.Doctor doctor;

        private Model.Address selectedAddress;

        public FrmDoctor()
        {
            InitializeComponent();
        }

        public FrmDoctor(Model.Doctor editDoctor)
        {
            InitializeComponent();

            doctor = editDoctor;
            selectedAddress = editDoctor.Address;
            tbSubjectArea.Text = editDoctor.SubjectArea;
            tbNote.Text = editDoctor.Note;

            InitializeAddresses();
        }

        private void InitializeAddresses()
        {
            tb_name.Text = selectedAddress.Name;
            tb_streetAndHouseNr.Text = selectedAddress.Street + " " + selectedAddress.HouseNr;
            tb_plzAndVillage.Text = selectedAddress.Plz + " " + selectedAddress.Village;
            tb_country.Text = selectedAddress.Country;
            tb_telNr.Text = selectedAddress.TelNr;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (selectedAddress == null)
            {
                MessageBox.Show("Der Arzt kann nicht gespeichert werden ohne gültige Adressdaten.");
            }
            else
            {
                if (doctor != null) // edit handover doctor
                {
                    doctor.Address = selectedAddress;
                    doctor.SubjectArea = tbSubjectArea.Text;
                    doctor.Note = tbNote.Text;

                    doctor.Update();
                }
                else
                {
                    doctor = new Model.Doctor(selectedAddress, tbSubjectArea.Text, tbNote.Text); // create new doctor
                }
                this.DialogResult = DialogResult.OK;
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
                        var address = formAddress.Address;

                        selectedAddress = address;

                        InitializeAddresses();
                    }
                }
            }
        }
    }
}
