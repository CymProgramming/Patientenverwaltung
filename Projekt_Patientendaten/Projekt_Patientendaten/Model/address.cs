using System;

namespace Projekt_Patientendaten.Model
{
    public class Address
    {
        public Address()
        {
        }



        public int Id { get; private set; }
        public string Name { get; set; }

        public int Plz { get; set; }

        public string Country { get; set; }

        public string Street { get; set; }

        public string HouseNr { get; set; }

        public string Village { get; set; }

        public string TelNr { get; set; }

        public string Note { get; set; }

        public void SetAddress(int id, string name, int plz, string country, string street, string houseNr, string village,
            string telNr, string note)
        {
            Id = id;
            Name = name;
            Plz = plz;
            Country = country;
            Street = street;
            HouseNr = houseNr;
            Village = village;
            TelNr = telNr;
            Note = note;
        }
        
        public Address(string name, int plz, string country, string street, string houseNr, string village, string telNr,
            string note)
        {
            Id = 0;
            Name = name;
            Plz = plz;
            Country = country;
            Street = street;
            HouseNr = houseNr;
            Village = village;
            TelNr = telNr;
            Note = note;

            Id = Databasemanager.SaveAddress(this);
        }

        public void Update()
        {
            Databasemanager.UpdateAddress(this);
        }

        public string GetAddress()
        {
            var address = Name;

            address += "/r /n " + Street + " " + HouseNr;
            address += "/r /n " + Plz + " " + Village;
            address += "/r /n " + Country;

            return address;
        }

        public bool SetId(int id)
        {
            var success = false;

            if (id == 0)
            {
                Id = id;
                success = true;
            }

            return success;
        }
    }
}