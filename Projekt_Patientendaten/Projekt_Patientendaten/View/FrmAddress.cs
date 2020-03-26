using System;
using System.Windows.Forms;
using Projekt_Patientendaten.Model;

namespace Projekt_Patientendaten
{
    public partial class FrmAddress : Form
    {

        public FrmAddress() // create new address
        {
            InitializeComponent();
        }

        public FrmAddress(Model.Address address) //edit handover address
        {
            InitializeComponent();

            Address = address;
            
            tbName.Text = address.Name;
            tbPlz.Text = Convert.ToString(address.Plz);
            tbStreet.Text = address.Street;
            tbVillage.Text = address.Village;
            tbHouseNr.Text = address.HouseNr;
            tbCountry.Text = address.Country;
            tbTelNr.Text = address.TelNr;
            tbNote.Text = address.Note;
        }

        public Model.Address Address { get; private  set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            const string argumentNullError = "Die Adressdaten können nicht gespeichert werden ohne ";
            const string strName = "einen gültigen Namen.";
            const string strStreet = "eine gültige Straße.";
            const string strHouseNr = "eine gültige Hausnummer.";
            const string strPlz = "eine gültige Postleitzahl.";
            const string strVillage = "eine gültige Stadt.";
            const string strCountry = "ein gültiges Land.";
            

            if (tbName.Text == String.Empty)
            {
                MessageBox.Show(argumentNullError + strName);
            }
            else if (tbStreet.Text == String.Empty)
            {
                MessageBox.Show(argumentNullError + strStreet);
            }
            else if (tbHouseNr.Text == String.Empty)
            {
                MessageBox.Show(argumentNullError + strHouseNr);
            }
            else if (tbPlz.Text == String.Empty)
            {
                MessageBox.Show(argumentNullError + strPlz);
            }
            else if (tbVillage.Text == String.Empty)
            {
                MessageBox.Show(argumentNullError + strVillage);
            }
            else if (tbCountry.Text == String.Empty)
            {
                MessageBox.Show(argumentNullError + strCountry);
            }
            else
            {
                if (int.TryParse(tbPlz.Text, out var plz))
                {
                    var name = tbName.Text;
                    var street = tbStreet.Text;
                    var village = tbVillage.Text;
                    var houseNr = tbHouseNr.Text;
                    var country = tbCountry.Text;
                    var telNr = tbTelNr.Text;
                    var note = tbNote.Text;

                    if (Address != null) // edit handover address
                    {
                        Address.Name = tbName.Text;
                        Address.Street = tbStreet.Text;
                        Address.Village = tbVillage.Text;
                        Address.HouseNr = tbHouseNr.Text;
                        Address.Country = tbCountry.Text;
                        Address.TelNr = tbTelNr.Text;
                        Address.Note = tbNote.Text;
                        Address.Plz = plz;
                        Address.Update();
                    }
                    else
                    {
                        Address = new Address(name, plz, country, street, houseNr, village, telNr, note); // create new address
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(argumentNullError + strPlz);
                }
            }
        }
    }
}