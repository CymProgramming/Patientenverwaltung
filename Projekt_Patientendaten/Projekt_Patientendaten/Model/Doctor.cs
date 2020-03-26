namespace Projekt_Patientendaten.Model
{
    public class Doctor
    {
        public Doctor()
        {
        }

        //public Doctor(int id, Address address, string subjectArea, string note)
        //{
        //    this.Id = id;
        //    this.Address = address;
        //    this.SubjectArea = subjectArea;
        //    this.Note = note;
        //}

        public Doctor(Address address, string subjectArea, string note)
        {
            Id = 0;
            Address = address;
            SubjectArea = subjectArea;
            Note = note;

            Id = Databasemanager.SaveDoctor(this);
        }

        public string Name
        {
            get => Address.Name;
            set => Address.Name = value;
        }
        public int Id { get; private set; }
        public string SubjectArea { get; set; }
        public string Note { get; set; }
        internal Address Address { get; set; }

        public void Update()
        {
            Databasemanager.UpdateDoctor(this);
        }

        public void SetValues(int id, Address address, string subjectArea, string note)
        {
            Id = id;
            Address = address;
            SubjectArea = subjectArea;
            Note = note;
        }

        public bool SetId(int id)
        {
            const bool success = true;

            if (Id != 0) return false;

            Id = id;
            return success;
        }
    }
}