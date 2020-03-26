namespace Projekt_Patientendaten.Model
{
    public class InsuranceAgency
    {
        public InsuranceAgency()
        {
        }

        public InsuranceAgency(Address address, string note)
        {
            Id = 0;
            Address = address;
            Note = note;

            Id = Databasemanager.SaveInsuranceAgency(this);
        }

        public string Name
        {
            get => Address.Name;
            set => Address.Name = value;
        }

        public string Note { get; set; }

        internal Address Address { get; set; }

        public int Id { get; set; }

        //public InsuranceAgency(int id, Address address, string note)
        //{
        //    this.Id = id;
        //    this.Address = address;
        //    this.Note = note;
        //}

        public void Update()
        {
            Databasemanager.UpdateInsuranceAgency(this);
        }

        public bool SetId(int id)
        {
            var success = false;

            if (Id == 0)
            {
                success = true;
                Id = id;
            }

            return success;
        }

        public bool SetValues(int id, Address address, string note)
        {
            var success = true;

            if (Id == 0)
            {
                Id = id;
                Address = address;
                Note = note;
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}