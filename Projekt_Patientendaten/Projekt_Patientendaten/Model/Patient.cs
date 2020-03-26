using System;
using System.Collections.Generic;

namespace Projekt_Patientendaten.Model
{
    public class Patient
    {
        public Patient(int id, DateTime birthday, string gender, InsuranceAgency insuranceAgency, int insuranceNr,
            Doctor localDoctor, Address address, string note) //für implementierung aus Datenbankdaten
        {
            Id = id;
            Birthday = birthday;
            Gender = gender;
            InsuranceAgency = insuranceAgency;
            InsuranceNr = insuranceNr;
            LocalDoctor = localDoctor;
            Address = address;
            Note = note;
            Treatments = Databasemanager.GetTreatments(id);
        }

        public Patient(DateTime birthday, string gender, InsuranceAgency insuranceAgency, int insuranceNr,
            Doctor localDoctor, Address address, string note) //für Neuimplementierung
        {
            Birthday = birthday;
            Gender = gender;
            InsuranceAgency = insuranceAgency;
            InsuranceNr = insuranceNr;
            LocalDoctor = localDoctor;
            Address = address;
            Note = note;
            Id = Databasemanager.SavePatient(this);
            Treatments = new List<Treatment>();
        }

        public string Name
        {
            get => Address.Name;
            set => Address.Name = value;
        }

        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        internal InsuranceAgency InsuranceAgency { get; set; }
        public int InsuranceNr { get; set; }
        internal Doctor LocalDoctor { get; set; }
        internal Address Address { get; set; }
        public string Note { get; set; }
        public int Id { get; private set; }

        public List<Treatment> Treatments { get; set; }

        public void Update()
        {
            Databasemanager.UpdatePatient(this);
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

        //public Patient(DateTime birthday, string gender, InsuranceAgency insurance_agency, int insurance_nr, Doctor local_doctor, Address address, string note)
        //{
        //    this.Birthday = birthday;
        //    this.Gender = gender;
        //    this.InsuranceAgency = insurance_agency;
        //    this.InsuranceNr = insurance_nr;
        //    this.LocalDoctor = local_doctor;
        //    this.Address = address;
        //    this.Note = note;

        //    Id = Databasemanager.SavePatient(this);
        //}

        //public Patient(DateTime birthday, string gender, Address address)
        //{
        //    this.Birthday = birthday;
        //    this.Gender = gender;
        //    this.Address = address;
        //    this.Note = " ";

        //    Id = Databasemanager.SavePatient(this);
        //}
    }
}