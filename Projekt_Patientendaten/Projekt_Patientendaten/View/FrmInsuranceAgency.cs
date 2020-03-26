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
    public partial class FrmInsuranceAgency : Form
    {
        public Model.InsuranceAgency insuranceAgency;

        private Model.Address selectedAddress;

        public FrmInsuranceAgency()
        {
            InitializeComponent();
        }

        public FrmInsuranceAgency(Model.InsuranceAgency editInsuranceAgency)
        {
            InitializeComponent();

            insuranceAgency = editInsuranceAgency;
            selectedAddress = editInsuranceAgency.Address;
            tbNote.Text = editInsuranceAgency.Note;

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
                MessageBox.Show("Die Krankenkasse kann nicht gespeichert werden ohne gültige Adressdaten.");
            }
            else
            {
                if (insuranceAgency != null) // edit handover insuranceAgency
                {
                    insuranceAgency.Address = selectedAddress;
                    insuranceAgency.Note = tbNote.Text;

                    insuranceAgency.Update();
                }
                else
                {
                    insuranceAgency = new Model.InsuranceAgency(selectedAddress, tbNote.Text); // create new insuranceAgency
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

                        selectedAddress = formAddress.Address;

                        InitializeAddresses();
                    }
                }
            }
        }
    }
}
