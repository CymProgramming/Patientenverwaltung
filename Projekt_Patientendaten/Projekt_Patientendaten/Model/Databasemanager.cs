using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Projekt_Patientendaten.Model
{
    //public enum SqlAddressIndexes
    //{
    //    Id = 0,
    //    Name = 1, 
    //    Plz = 2, 
    //    Street = 3,
    //    Village = 4,
    //    HouseNr = 5, 
    //    Country = 6, 
    //    TelNr = 7, 
    //    Note = 8,
    //}

    public static class Fieldnames
    {
        public static class Patients
        {
            public enum Index
            {
                Id,
                Birthday,
                Gender,
                Insurance,
                InsuranceNr,
                LocalDoctor,
                Address,
                Note
            }

            public const string TableName = "Patients";
            public const string Birthday = "Birthday";
            public const string Gender = "Gender";
            public const string Insurance = "Insurance";
            public const string InsuranceNr = "Insurance_Nr";
            public const string LocalDoctor = "Local_Doctor";
            public const string Address = "Address";
            public const string Note = "Note";
            public const string Id = "ID";
        }

        public static class Addresses
        {
            public enum Index
            {
                Id,
                Name,
                Plz,
                Street,
                Village,
                HouseNr,
                Country,
                TelNr,
                Note
            }

            public const string Id = "ID";
            public const string TableName = "Addresses";
            public const string Name = "Name";
            public const string Plz = "Plz";
            public const string Street = "Street";
            public const string Village = "Village";
            public const string HouseNr = "HouseNr";
            public const string Country = "Country";
            public const string TelNr = "TelNr";
            public const string Note = "Note";
        }

        public static class Doctors
        {
            public enum Index
            {
                Id,
                Address,
                SubjectArea,
                Note
            }

            public const string Id = "ID";
            public const string TableName = "Doctors";
            public const string Address = "Address";
            public const string SubjectArea = "SubjectArea";
            public const string Note = "Note";
        }

        public static class InsuranceAgencys
        {
            public enum Index
            {
                Id,
                Address,
                Note
            }

            public const string Id = "ID";
            public const string TableName = "InsuranceAgencys";
            public const string Address = "Address";
            public const string Note = "Note";
        }

        public static class Treatments
        {
            public enum Index
            {
                Id,
                PatientId,
                Date,
                Entry,
                Medication,
                Note
            }

            public const string Tablename = "Treatments";
            public const string PatientId = "Patient_ID";
            public const string Date = "Date";
            public const string Entry = "Entry";
            public const string Medication = "Medication";
            public const string Note = "Note";
            public const string Id = "ID";
        }
    }

    internal static class Databasemanager
    {
        private const int EmptyIntValue = 0;
        private static readonly ArgumentException DataError = new ArgumentException();
        


        public static void ClearDatabase()
        {
            var sql = $"DELETE FROM {Fieldnames.Addresses.TableName}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.CommandText = $"DELETE FROM {Fieldnames.Doctors.TableName}";
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.CommandText = $"DELETE FROM {Fieldnames.Patients.TableName}";
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.CommandText = $"DELETE FROM {Fieldnames.Treatments.Tablename}";
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.CommandText = $"DELETE FROM {Fieldnames.InsuranceAgencys.TableName}";
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.CommandText = "DELETE FROM sqlite_sequence";
                    command.ExecuteNonQuery();
                }
            }
        }

        #region Dummy

        //public static void DummyMethod()
        //{
        //    var sql = "";

        //    using (SQLiteConnection c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
        //    {
        //        c.Open();

        //        using (SQLiteCommand command = new SQLiteCommand(sql, c))
        //        {

        //            using (SQLiteDataReader reader = command.ExecuteReader())
        //            {
        //                reader.Read();
        //            }
        //        }
        //    }
        //}

        #endregion

        #region AddDataset

        public static int SavePatient(Patient patient)
        {
            int maxId;

            var sqlInsert =
                $"INSERT INTO {Fieldnames.Patients.TableName}({Fieldnames.Patients.Birthday}, {Fieldnames.Patients.Gender}, {Fieldnames.Patients.Insurance}, {Fieldnames.Patients.InsuranceNr}, {Fieldnames.Patients.LocalDoctor}, {Fieldnames.Patients.Address}, {Fieldnames.Patients.Note})";
            sqlInsert +=
                $"VALUES(@{Fieldnames.Patients.Birthday}, @{Fieldnames.Patients.Gender}, @{Fieldnames.Patients.Insurance}, @{Fieldnames.Patients.InsuranceNr}, @{Fieldnames.Patients.LocalDoctor}, @{Fieldnames.Patients.Address}, @{Fieldnames.Patients.Note})";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sqlInsert, c))
                {
                    command.Parameters.Add($"@{Fieldnames.Patients.Birthday}", DbType.String).Value =
                        Convert.ToString(patient.Birthday);
                    command.Parameters.Add($"@{Fieldnames.Patients.Gender}", DbType.String).Value =
                        patient.Gender;
                    command.Parameters.Add($"@{Fieldnames.Patients.InsuranceNr}", DbType.Int32).Value =
                        patient.InsuranceNr;
                    command.Parameters.Add($"@{Fieldnames.Patients.Address}", DbType.Int32).Value =
                        patient.Address.Id;
                    command.Parameters.Add($"@{Fieldnames.Patients.Note}", DbType.String).Value =
                        patient.Note;

                    if (patient.InsuranceAgency != null)
                        command.Parameters.Add($"@{Fieldnames.Patients.Insurance}", DbType.Int32).Value =
                            patient.InsuranceAgency.Id;
                    else
                        command.Parameters.Add($"@{Fieldnames.Patients.Insurance}", DbType.Int32).Value =
                            EmptyIntValue;

                    if (patient.LocalDoctor != null)
                        command.Parameters.Add($"@{Fieldnames.Patients.LocalDoctor}", DbType.Int32).Value =
                            patient.LocalDoctor.Id;
                    else
                        command.Parameters.Add($"@{Fieldnames.Patients.LocalDoctor}", DbType.Int32).Value =
                            EmptyIntValue;

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.CommandText = $"select max(Id) from {Fieldnames.Patients.TableName}";

                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        maxId = reader.GetInt32(0);
                        patient.SetId(maxId);
                    }
                }
            }

            return maxId;
        }

        public static int SaveAddress(Address address)
            // rückgabe Id von hinzugefügter Adresse
        {
            int maxId;

            var sqlAddress =
                $"INSERT INTO {Fieldnames.Addresses.TableName}({Fieldnames.Addresses.Name}, {Fieldnames.Addresses.Plz}, {Fieldnames.Addresses.Street}, {Fieldnames.Addresses.Village}, {Fieldnames.Addresses.HouseNr}, {Fieldnames.Addresses.Country}, {Fieldnames.Addresses.TelNr}, {Fieldnames.Addresses.Note})";
            sqlAddress +=
                $" VALUES(@{Fieldnames.Addresses.Name}, @{Fieldnames.Addresses.Plz}, @{Fieldnames.Addresses.Street}, @{Fieldnames.Addresses.Street}, @{Fieldnames.Addresses.HouseNr}, @{Fieldnames.Addresses.Country}, @{Fieldnames.Addresses.HouseNr}, @{Fieldnames.Addresses.Note})";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sqlAddress, c))
                {
                    command.Parameters.Add($"@{Fieldnames.Addresses.Name}", DbType.String).Value =
                        address.Name;
                    command.Parameters.Add($"@{Fieldnames.Addresses.Plz}", DbType.Int32).Value =
                        address.Plz;
                    command.Parameters.Add($"@{Fieldnames.Addresses.Street}", DbType.String).Value =
                        address.Street;
                    command.Parameters.Add($"@{Fieldnames.Addresses.Village}", DbType.String).Value =
                        address.Village;
                    command.Parameters.Add($"@{Fieldnames.Addresses.HouseNr}", DbType.String).Value =
                        address.HouseNr;
                    command.Parameters.Add($"@{Fieldnames.Addresses.Country}", DbType.String).Value =
                        address.Country;
                    command.Parameters.Add($"@{Fieldnames.Addresses.TelNr}", DbType.String).Value =
                        address.TelNr;
                    command.Parameters.Add($"@{Fieldnames.Addresses.Note}", DbType.String).Value =
                        address.Note;
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.CommandText = $"select max(Id) from {Fieldnames.Addresses.TableName}";

                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        maxId = reader.GetInt32(0);
                        address.SetId(maxId); 
                    }
                }
            }
            return maxId;
        }

        public static int SaveInsuranceAgency(InsuranceAgency agency)
        {
            int maxId;

            var sql =
                $"INSERT INTO {Fieldnames.InsuranceAgencys.TableName}({Fieldnames.InsuranceAgencys.Address}, {Fieldnames.InsuranceAgencys.Note})";
            sql += " VALUES(@Address, @Note)";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    command.Parameters.Add("@Address", DbType.Int32).Value = agency.Address.Id;
                    command.Parameters.Add("@Note", DbType.String).Value = agency.Note;
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.CommandText = $"select max(Id) from {Fieldnames.InsuranceAgencys.TableName}";

                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        maxId = reader.GetInt32(0);
                        agency.Id = maxId;
                    }
                }
            }

            return maxId;
        }

        public static int SaveDoctor(Doctor doctor)
        {
            int maxId;

            var sql =
                $"INSERT INTO {Fieldnames.Doctors.TableName}({Fieldnames.Doctors.Address}, {Fieldnames.Doctors.SubjectArea}, {Fieldnames.Doctors.Note})";
            sql +=
                $" VALUES(@{Fieldnames.Doctors.Address}, @{Fieldnames.Doctors.SubjectArea}, @{Fieldnames.Doctors.Note})";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    command.Parameters.Add($"@{Fieldnames.Doctors.Address}", DbType.Int32).Value =
                        doctor.Address.Id;
                    command.Parameters.Add($"@{Fieldnames.Doctors.SubjectArea}", DbType.String).Value =
                        doctor.SubjectArea;
                    command.Parameters.Add($"@{Fieldnames.Doctors.Note}", DbType.String).Value =
                        doctor.Note;
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.CommandText = $"select max(Id) from {Fieldnames.Doctors.TableName}";

                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        maxId = reader.GetInt32(0);
                        doctor.SetId(maxId); 
                    }
                }
            }

            return maxId;
        }

        public static int SaveTreatment(Treatment treatment)
        {
            var sql =
                $"INSERT INTO {Fieldnames.Treatments.Tablename}({Fieldnames.Treatments.PatientId}, {Fieldnames.Treatments.Date}, {Fieldnames.Treatments.Entry}, {Fieldnames.Treatments.Medication}, {Fieldnames.Treatments.Note})";
            sql +=
                $"VALUES(@{Fieldnames.Treatments.PatientId}, @{Fieldnames.Treatments.Date}, @{Fieldnames.Treatments.Entry}, @{Fieldnames.Treatments.Medication}, @{Fieldnames.Treatments.Note})";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    command.Parameters.Add($"@{Fieldnames.Treatments.PatientId}", DbType.Int32).Value =
                        treatment.PatientId;
                    command.Parameters.Add($"@{Fieldnames.Treatments.Date}", DbType.String).Value =
                        Convert.ToString(treatment.Date);
                    command.Parameters.Add($"@{Fieldnames.Treatments.Entry}", DbType.String).Value = treatment.Entry;
                    command.Parameters.Add($"@{Fieldnames.Treatments.Medication}", DbType.String).Value =
                        treatment.Medication;
                    command.Parameters.Add($"@{Fieldnames.Treatments.Note}", DbType.String).Value = treatment.Note;

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.CommandText = $"SELECT max(Id) FROM {Fieldnames.Treatments.Tablename}";

                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        var maxId = reader.GetInt32(0);
                        treatment.SetId(maxId); 
                        return maxId;
                    }
                }
            }
        }

        #endregion

        #region GetDataset

        public static List<Patient> GetPatients()
        {
            var patients = new List<Patient>();
            var sql = $"SELECT * FROM {Fieldnames.Patients.TableName}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32((int) Fieldnames.Patients.Index.Id);
                            var birthdayStr = reader.GetString((int) Fieldnames.Patients.Index.Birthday);
                            var gender = reader.GetString((int) Fieldnames.Patients.Index.Gender);
                            var insuranceId = reader.GetInt32((int) Fieldnames.Patients.Index.Insurance);
                            var insuranceNr = reader.GetInt32((int) Fieldnames.Patients.Index.InsuranceNr);
                            var localDoctorId = reader.GetInt32((int) Fieldnames.Patients.Index.LocalDoctor);
                            var addressId = reader.GetInt32((int) Fieldnames.Patients.Index.Address);
                            var note = reader.GetString((int) Fieldnames.Patients.Index.Note);

                            var address = GetAddress(addressId);
                            var insuranceAgency = GetInsuranceAgency(insuranceId);
                            var localDoctor = GetDoctor(localDoctorId);
                            var birthday = Convert.ToDateTime(birthdayStr);
                            var treatments = GetTreatments(id);


                            var patient = new Patient(id, birthday, gender, insuranceAgency, insuranceNr, localDoctor,
                                address, note) {Treatments = treatments};
                            patients.Add(patient);
                        }
                    }
                }
            }

            return patients;
        }

        public class PatientData
        {
            public PatientData(string id, string name, string birthday, string doctor, string insurance,
                string treatments, string lastMedication)
            {
                Id = id ?? throw new ArgumentNullException(nameof(id));
                Name = name ?? throw new ArgumentNullException(nameof(name));
                Birthday = birthday ?? throw new ArgumentNullException(nameof(birthday));
                Doctor = doctor ?? throw new ArgumentNullException(nameof(doctor));
                Insurance = insurance ?? throw new ArgumentNullException(nameof(insurance));
                Treatments = treatments ?? throw new ArgumentNullException(nameof(treatments));
                LastMedication = lastMedication ?? throw new ArgumentNullException(nameof(lastMedication));
            }

            public  string Id { get; set;  }
            public  string Name { get; set; }
            public  string Birthday { get; set; }
            public  string Doctor { get; set; }
            public  string Insurance { get; set; }
            public  string Treatments { get; set; }
            public  string LastMedication { get; set; }
        }

        public static BindingList<PatientData> GetPatientsAsStrings() // data for filling the datagridview
        {
            var patients = new BindingList<PatientData>();
            var sql = $"SELECT * FROM {Fieldnames.Patients.TableName}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32((int) Fieldnames.Patients.Index.Id);
                            var birthdayStr = reader.GetString((int) Fieldnames.Patients.Index.Birthday);
                            var gender = reader.GetString((int) Fieldnames.Patients.Index.Gender);
                            var insuranceId = reader.GetInt32((int) Fieldnames.Patients.Index.Insurance);
                            var insuranceNr = reader.GetInt32((int) Fieldnames.Patients.Index.InsuranceNr);
                            var localDoctorId = reader.GetInt32((int) Fieldnames.Patients.Index.LocalDoctor);
                            var addressId = reader.GetInt32((int) Fieldnames.Patients.Index.Address);
                            var note = reader.GetString((int) Fieldnames.Patients.Index.Note);

                            var address = GetAddress(addressId);
                            var insuranceAgency = GetInsuranceAgency(insuranceId);
                            var localDoctor = GetDoctor(localDoctorId);
                            var birthday = Convert.ToDateTime(birthdayStr).Date;
                            var treatments = GetTreatments(Convert.ToInt32(id));

                            var lastMedication = "";

                            if (treatments.Count != 0)
                            {
                                lastMedication = treatments.Last().Medication;
                            }

                            var patientdata = new PatientData(Convert.ToString(id), address.Name, birthdayStr, localDoctor.Address.Name, insuranceAgency.Address.Name, Convert.ToString(treatments.Count), lastMedication);
                            patients.Add(patientdata);
                        }
                    }
                }
            }
            return patients;
        }

        private static Address GetAddress(int addressId)
        {
            var address = new Address();
            var sql = $"SELECT * FROM {Fieldnames.Addresses.TableName} WHERE ID = " + Convert.ToString(addressId);

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var id = reader.GetInt32((int) Fieldnames.Addresses.Index.Id);
                            var plz = reader.GetInt32((int) Fieldnames.Addresses.Index.Plz);
                            var houseNr = reader.GetString((int) Fieldnames.Addresses.Index.HouseNr);
                            var telNr = reader.GetString((int) Fieldnames.Addresses.Index.TelNr);
                            var name = reader.GetString((int) Fieldnames.Addresses.Index.Name);
                            var street = reader.GetString((int) Fieldnames.Addresses.Index.Street);
                            var village = reader.GetString((int) Fieldnames.Addresses.Index.Village);
                            var country = reader.GetString((int) Fieldnames.Addresses.Index.Country);
                            var note = reader.GetString((int) Fieldnames.Addresses.Index.Note);

                            address.SetAddress(id, name, plz, country, street, houseNr, village, telNr, note);
                        }
                        else
                        {
                            throw DataError;
                        }
                    }
                }
            }

            return address;
        }

        public static List<Address> GetAddresses()
        {
            var addresses = new List<Address>();
            var sql = $"SELECT * FROM {Fieldnames.Addresses.TableName} ORDER BY {Fieldnames.Addresses.Name}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32((int)Fieldnames.Addresses.Index.Id);
                            var name = reader.GetString((int)Fieldnames.Addresses.Index.Name);
                            var plz = reader.GetInt32((int)Fieldnames.Addresses.Index.Plz);
                            var street = reader.GetString((int)Fieldnames.Addresses.Index.Street);
                            var village = reader.GetString((int)Fieldnames.Addresses.Index.Village);
                            var houseNr = reader.GetString((int)Fieldnames.Addresses.Index.HouseNr);
                            var country = reader.GetString((int)Fieldnames.Addresses.Index.Country);
                            var telNr = reader.GetString((int)Fieldnames.Addresses.Index.TelNr);
                            var note = reader.GetString((int)Fieldnames.Addresses.Index.Note);

                            var address = new Address();
                            address.SetAddress(id, name, plz, country, street, houseNr, village, telNr, note);
                            addresses.Add(address);
                        }
                    }
                }
            }

            return addresses;
        }

        private static InsuranceAgency GetInsuranceAgency(int insuranceAgencyId)
        {
            var insuranceAgency = new InsuranceAgency();
            var sql = $"SELECT * FROM {Fieldnames.InsuranceAgencys.TableName} WHERE ID = " +
                      Convert.ToString(insuranceAgencyId);

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var id = reader.GetInt32((int) Fieldnames.InsuranceAgencys.Index.Id);
                            var addressId = reader.GetInt32((int) Fieldnames.InsuranceAgencys.Index.Address);
                            var note = reader.GetString((int) Fieldnames.InsuranceAgencys.Index.Note);

                            var address = GetAddress(addressId);
                            insuranceAgency.SetValues(id, address, note);
                        }
                        else
                        {
                            throw DataError;
                        }
                    }
                }
            }

            return insuranceAgency;
        }

        public static List<InsuranceAgency> GetInsuranceAgencies()
        {
            var agencies = new List<InsuranceAgency>();
            var sql = $"SELECT * FROM {Fieldnames.InsuranceAgencys.TableName}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32((int)Fieldnames.InsuranceAgencys.Index.Id);
                            var addressId = reader.GetInt32((int)Fieldnames.InsuranceAgencys.Index.Address);
                            var note = reader.GetString((int)Fieldnames.InsuranceAgencys.Index.Note);

                            Address address = GetAddress(addressId);

                            var agency = new InsuranceAgency();
                            agency.SetValues(id, address, note);
                            agencies.Add(agency);
                        }
                    }
                }
            }

            return agencies;
        }

        private static Doctor GetDoctor(int doctorId)
        {
            var doctor = new Doctor();

            var sql = $"SELECT * FROM {Fieldnames.Doctors.TableName} WHERE {Fieldnames.Doctors.Id} = " +
                      Convert.ToString(doctorId);

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var id = reader.GetInt32((int) Fieldnames.Doctors.Index.Id);
                            var addressId = reader.GetInt32((int) Fieldnames.Doctors.Index.Address);
                            var subjectArea = reader.GetString((int) Fieldnames.Doctors.Index.SubjectArea);
                            var note = reader.GetString((int) Fieldnames.Doctors.Index.Note);
                            var address = GetAddress(addressId);

                            doctor.SetValues(id, address, subjectArea, note);
                        }
                        else
                        {
                            throw DataError;
                        }
                    }
                }
            }

            return doctor;
        }

        public static List<Doctor> GetDoctors()
        {
            var doctors = new List<Doctor>();
            var sql = $"SELECT * FROM {Fieldnames.Doctors.TableName}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32((int)Fieldnames.Doctors.Index.Id);
                            var addressId = reader.GetInt32((int)Fieldnames.Doctors.Index.Address);
                            var subjectArea = reader.GetString((int)Fieldnames.Doctors.Index.SubjectArea);
                            var note = reader.GetString((int)Fieldnames.Doctors.Index.Note);

                            Address address = GetAddress(addressId);

                            var doctor = new Doctor();
                            doctor.SetValues(id, address, subjectArea, note);
                            doctors.Add(doctor);
                        }
                    }
                }
            }

            return doctors;
        }

        public static List<Treatment> GetTreatments(int patientId)
        {
            var treatments = new List<Treatment>();
            var sql = $"SELECT * FROM {Fieldnames.Treatments.Tablename} WHERE {Fieldnames.Treatments.PatientId} = " +
                      Convert.ToString(patientId);

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sql, c))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32((int) Fieldnames.Treatments.Index.Id);
                            var dateStr = reader.GetString((int) Fieldnames.Treatments.Index.Date);
                            var entry = reader.GetString((int) Fieldnames.Treatments.Index.Entry);
                            var medication = reader.GetString((int) Fieldnames.Treatments.Index.Medication);
                            var note = reader.GetString((int) Fieldnames.Treatments.Index.Note);

                            var date = Convert.ToDateTime(dateStr);
                            var treatmentTemp = new Treatment(patientId, date, entry, medication, note, id);
                            treatments.Add(treatmentTemp);
                        }
                    }
                }
            }

            return treatments;
        }

        #endregion

        #region UpdateDataset

        public static void UpdateAddress(Address address)
        {
            var validDataSet = false;
            
            var sqlCheck =
                $"SELECT * FROM {Fieldnames.Addresses.TableName} WHERE {Fieldnames.Addresses.Id} = @{Fieldnames.Addresses.Id}";
            
            
            var sqlUpdate = $"UPDATE {Fieldnames.Addresses.TableName} SET " +
                      $"{Fieldnames.Addresses.Name} = @{Fieldnames.Addresses.Name}, " +
                      $"{Fieldnames.Addresses.Plz} = @{Fieldnames.Addresses.Plz}, " +
                      $"{Fieldnames.Addresses.Street} = @{Fieldnames.Addresses.Street}, " +
                      $"{Fieldnames.Addresses.Village} = @{Fieldnames.Addresses.Village}, " +
                      $"{Fieldnames.Addresses.HouseNr} = @{Fieldnames.Addresses.HouseNr}, " +
                      $"{Fieldnames.Addresses.Country} = @{Fieldnames.Addresses.Country}, " +
                      $"{Fieldnames.Addresses.TelNr} = @{Fieldnames.Addresses.TelNr}, " +
                      $"{Fieldnames.Addresses.Note} = @{Fieldnames.Addresses.Note} " +
                      $"WHERE {Fieldnames.Addresses.Id} = @{Fieldnames.Addresses.Id}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sqlCheck, c))
                {
                    command.Parameters.Add($@"{Fieldnames.Addresses.Id}", DbType.Int32).Value = address.Id;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            validDataSet = true;
                        }
                    }
                    
                    if (validDataSet)
                    {
                        command.Parameters.Clear();
                        command.CommandText = sqlUpdate;
                        
                        command.Parameters.Add($"@{Fieldnames.Addresses.Name}", DbType.String).Value = address.Name;
                        command.Parameters.Add($"@{Fieldnames.Addresses.Plz}", DbType.Int32).Value = address.Plz;
                        command.Parameters.Add($"@{Fieldnames.Addresses.Street}", DbType.String).Value = address.Street;
                        command.Parameters.Add($"@{Fieldnames.Addresses.Village}", DbType.String).Value = address.Village;
                        command.Parameters.Add($"@{Fieldnames.Addresses.HouseNr}", DbType.String).Value = address.HouseNr;
                        command.Parameters.Add($"@{Fieldnames.Addresses.Country}", DbType.String).Value = address.Country;
                        command.Parameters.Add($"@{Fieldnames.Addresses.TelNr}", DbType.String).Value = address.TelNr;
                        command.Parameters.Add($"@{Fieldnames.Addresses.Note}", DbType.String).Value = address.Note;
                        command.Parameters.Add($"@{Fieldnames.Addresses.Id}", DbType.Int32).Value = address.Id;

                        command.ExecuteNonQuery();    
                    }
                }
            }
        }

        public static void UpdateDoctor(Doctor doctor)
        {
            var validDataSet = false;

            var sqlCheck =
                $"SELECT * FROM {Fieldnames.Doctors.TableName} WHERE {Fieldnames.Doctors.Id} = @{Fieldnames.Doctors.Id}";
            
            var sqlUpdate = $"UPDATE {Fieldnames.Doctors.TableName} SET " +
                      $"{Fieldnames.Doctors.Address} = @{Fieldnames.Doctors.Address}, " +
                      $"{Fieldnames.Doctors.SubjectArea} = @{Fieldnames.Doctors.SubjectArea}, " +
                      $"{Fieldnames.Doctors.Note} = @{Fieldnames.Doctors.Note} " +
                      $"WHERE {Fieldnames.Doctors.Id} = @{Fieldnames.Doctors.Id}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sqlCheck, c))
                {
                    command.Parameters.Add($@"{Fieldnames.Doctors.Id}", DbType.Int32).Value = doctor.Id;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            validDataSet = true;
                        }
                    }

                    if (validDataSet)
                    {
                        command.Parameters.Clear();
                        command.CommandText = sqlUpdate;
                        
                        command.Parameters.Add($"@{Fieldnames.Doctors.Address}", DbType.Int32).Value = doctor.Address.Id;
                        command.Parameters.Add($"@{Fieldnames.Doctors.SubjectArea}", DbType.String).Value =
                            doctor.SubjectArea;
                        command.Parameters.Add($"@{Fieldnames.Doctors.Note}", DbType.String).Value = doctor.Note;
                        command.Parameters.Add($@"{Fieldnames.Doctors.Id}", DbType.Int32).Value = doctor.Id;
                        command.ExecuteNonQuery();    
                    }
                    

                }
            }
        }

        public static void UpdateInsuranceAgency(InsuranceAgency insuranceAgency)
        {
            var validDataSet = false;

            var sqlCheck =
                $"SELECT * FROM {Fieldnames.InsuranceAgencys.TableName} WHERE {Fieldnames.InsuranceAgencys.Id} = @{Fieldnames.InsuranceAgencys.Id}";
            
            var sqlUpdate = $"UPDATE {Fieldnames.InsuranceAgencys.TableName} SET " +
                      $"{Fieldnames.InsuranceAgencys.Address} = @{Fieldnames.InsuranceAgencys.Address}, " +
                      $"{Fieldnames.InsuranceAgencys.Note} = @{Fieldnames.InsuranceAgencys.Note} " +
                      $"WHERE {Fieldnames.InsuranceAgencys.Id} = @{Fieldnames.InsuranceAgencys.Id}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sqlCheck, c))
                {
                    command.Parameters.Add($@"{Fieldnames.InsuranceAgencys.Id}", DbType.Int32).Value = insuranceAgency.Id;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            validDataSet = true;
                        }
                    }

                    if (validDataSet)
                    {
                        command.Parameters.Clear();
                        command.CommandText = sqlUpdate;
                        
                        command.Parameters.Add($"@{Fieldnames.InsuranceAgencys.Address}", DbType.Int32).Value =
                            insuranceAgency.Address.Id;
                        command.Parameters.Add($"@{Fieldnames.InsuranceAgencys.Note}", DbType.String).Value =
                            insuranceAgency.Note;
                        command.Parameters.Add($"@{Fieldnames.InsuranceAgencys.Id}", DbType.Int32).Value =
                            insuranceAgency.Id;

                        command.ExecuteNonQuery();    
                    }
                    
                }
            }
        }

        public static void UpdateTreatment(Treatment treatment)
        {
            var validDataSet = false;
            
            var sqlCheck
                = $"SELECT * FROM {Fieldnames.Treatments.Tablename} WHERE {Fieldnames.Treatments.Id} = @{Fieldnames.Treatments.Id}";
            
            var sqlUpdate = $"UPDATE {Fieldnames.Treatments.Tablename} SET " +
                      $"{Fieldnames.Treatments.PatientId} = @{Fieldnames.Treatments.PatientId}, " +
                      $"{Fieldnames.Treatments.Date} = @{Fieldnames.Treatments.Date}, " +
                      $"{Fieldnames.Treatments.Entry} = @{Fieldnames.Treatments.Entry}, " +
                      $"{Fieldnames.Treatments.Medication} = @{Fieldnames.Treatments.Medication}, " +
                      $"{Fieldnames.Treatments.Note} = @{Fieldnames.Treatments.Note} " +
                      $"WHERE {Fieldnames.Treatments.Id} = @{Fieldnames.Treatments.Id}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sqlCheck, c))
                {
                    command.Parameters.Add($@"{Fieldnames.Treatments.Id}", DbType.Int32).Value = treatment.Id;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            validDataSet = true;
                        }
                    }

                    if (validDataSet)
                    {
                        command.Parameters.Clear();
                        command.CommandText = sqlUpdate;

                        command.Parameters.Add($"@{Fieldnames.Treatments.PatientId}", DbType.Int32).Value =
                            treatment.PatientId;
                        command.Parameters.Add($"@{Fieldnames.Treatments.Date}", DbType.String).Value =
                            Convert.ToString(treatment.Date);
                        command.Parameters.Add($"@{Fieldnames.Treatments.Entry}", DbType.String).Value =
                            treatment.Entry;
                        command.Parameters.Add($"@{Fieldnames.Treatments.Medication}", DbType.String).Value =
                            treatment.Medication;
                        command.Parameters.Add($"@{Fieldnames.Treatments.Note}", DbType.String).Value =
                            treatment.Note;
                        command.Parameters.Add($"@{Fieldnames.Treatments.Id}", DbType.Int32).Value =
                            treatment.Id;

                        command.ExecuteNonQuery();   
                    }
                }
            }
        }


        public static void UpdatePatient(Patient patient)
        {
            var validDataSet = false;
            UpdateAddress(patient.Address);
            UpdateDoctor(patient.LocalDoctor);
            UpdateInsuranceAgency(patient.InsuranceAgency);

            foreach (var treatment in patient.Treatments) UpdateTreatment(treatment);
            
            var sqlCheck = $"SELECT * FROM {Fieldnames.Patients.TableName} WHERE {Fieldnames.Patients.Id} = @{Fieldnames.Patients.Id}";

            var sqlUpdate = $"UPDATE {Fieldnames.Patients.TableName} SET " +
                      $"{Fieldnames.Patients.Birthday} = @{Fieldnames.Patients.Birthday}, " +
                      $"{Fieldnames.Patients.Gender} = @{Fieldnames.Patients.Gender}, " +
                      $"{Fieldnames.Patients.Insurance} = @{Fieldnames.Patients.Insurance}, " +
                      $"{Fieldnames.Patients.InsuranceNr} = @{Fieldnames.Patients.InsuranceNr}, " +
                      $"{Fieldnames.Patients.LocalDoctor} = @{Fieldnames.Patients.LocalDoctor}, " +
                      $"{Fieldnames.Patients.Address} = @{Fieldnames.Patients.Address}, " +
                      $"{Fieldnames.Patients.Note} = @{Fieldnames.Patients.Note} " +
                      $"WHERE {Fieldnames.Patients.Id} = @{Fieldnames.Patients.Id}";

            using (var c = new SQLiteConnection(@"Data Source = ..\..\..\..\DB\MYDb.db; Version = 3;"))
            {
                c.Open();

                using (var command = new SQLiteCommand(sqlCheck, c))
                {
                    // Check ob datensatz vorhanden
                    command.Parameters.Add($@"{Fieldnames.Patients.Id}", DbType.Int32).Value = patient.Id;
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            validDataSet = true;
                        }
                    }
                    // Update datensatz
                    if (validDataSet)
                    {
                        command.Parameters.Clear();
                        command.CommandText = sqlUpdate;
                        
                        command.Parameters.Add($"@{Fieldnames.Patients.Birthday}", DbType.String).Value =
                            Convert.ToString(patient.Birthday);
                        command.Parameters.Add($"@{Fieldnames.Patients.Gender}", DbType.String).Value = patient.Gender;
                        command.Parameters.Add($"@{Fieldnames.Patients.Insurance}", DbType.Int32).Value =
                            patient.InsuranceAgency.Id;
                        command.Parameters.Add($"@{Fieldnames.Patients.InsuranceNr}", DbType.Int32).Value =
                            patient.InsuranceNr;
                        command.Parameters.Add($"@{Fieldnames.Patients.LocalDoctor}", DbType.Int32).Value =
                            patient.LocalDoctor.Id;
                        command.Parameters.Add($"@{Fieldnames.Patients.Address}", DbType.Int32).Value = patient.Address.Id;
                        command.Parameters.Add($"@{Fieldnames.Patients.Note}", DbType.String).Value = patient.Note;
                        command.Parameters.Add($@"{Fieldnames.Patients.Id}", DbType.Int32).Value = patient.Id;
                        
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        throw DataError;
                    }
                    
                }
            }
        }

        #endregion
    }
}