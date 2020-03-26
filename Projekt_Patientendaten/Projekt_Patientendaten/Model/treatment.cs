using System;

namespace Projekt_Patientendaten.Model
{
    public class Treatment
    {
        public Treatment(int patientId, DateTime date, string entry, string medication, string note)
        {
            PatientId = patientId;
            Date = date;
            Entry = entry;
            Medication = medication;
            Note = note;
            Id = Databasemanager.SaveTreatment(this);
        }


        public Treatment(int patientId, DateTime date, string entry, string medication, string note, int id)
        {
            PatientId = patientId;
            Date = date;
            Entry = entry ?? throw new ArgumentNullException(nameof(entry));
            Medication = medication ?? throw new ArgumentNullException(nameof(medication));
            Note = note ?? throw new ArgumentNullException(nameof(note));
            Id = id;
        }

        public void Update()
        {
            Databasemanager.UpdateTreatment(this);
        }

        public int PatientId { get; }

        public DateTime Date { get; private set; }

        public string Entry { get; set; }

        public string Medication { get; set; }

        public string Note { get; set; }

        public int Id { get; private set; }

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
    }
}