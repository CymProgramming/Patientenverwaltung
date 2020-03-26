using System;

namespace Projekt_Patientendaten.Model
{
    public static class TestData
    {
        public static Patient CreateTestPatient()
        {
            var birthday = new DateTime(1999, 6, 18);
            var patientAddress = new Address("Heinz Peter", 86732, "deutschland", "bobostraße", "1", "elefanthausen",
                "01768743793", "banana");
            var docAddress = new Address("Dr. Olaf Günter", 72722, "deutschland", "tiefstraße", "5", "tiefendorf",
                "0908287483", "no banana");
            var cassAddress = new Address("Aok Hb", 72572, "deutschland", "blubstraße", "52", "blubdorf", "065422483",
                "maybe banana");
            var insuranceAgency = new InsuranceAgency(cassAddress, "definitly banana");
            var doctor = new Doctor(docAddress, "Psychologie", "psychisch krank");


            var patient = new Patient(birthday, "male", insuranceAgency, 00001, doctor, patientAddress,
                "master Banana");
            var treatment = new Treatment(patient.Id, DateTime.Now, "testentry", "phenylpiracetam", "testnotiz");
            patient.Treatments.Add(treatment);

            return patient;
        }
    }
}