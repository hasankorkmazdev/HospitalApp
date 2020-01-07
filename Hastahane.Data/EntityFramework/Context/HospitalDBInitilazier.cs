using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane.Data.EntityFramework.Context
{
    class HospitalDBInitilazier : CreateDatabaseIfNotExists<HospitalDBContext>
    {
        protected override void Seed(HospitalDBContext context)
        {
            Models.Procces firstLook = new Models.Procces()
            {
                ProccesName = "İlk Muayene",
                ProccesDescription = "Doktor ile yapılan ilk işlem",
                isActive = true,
            };
            Models.Procces bloodProcces = new Models.Procces()
            {
                ProccesName = "Kan Alma",
                ProccesDescription = "Tahlil için kan alma işlemi",
                isActive = true,
            };
            Models.Procces tahlil1 = new Models.Procces()
            {
                ProccesName = "tahlil1",
                ProccesDescription = "Tahlil ",
                isActive = true,
            };
            Models.Procces tahlil2 = new Models.Procces()
            {
                ProccesName = "tahlil2",
                ProccesDescription = "Tahlil ",
                isActive = true,
            };
            Models.Patient patient = new Models.Patient()
            {
                TCNumber = "11111111111",
                Name = "Yusuf",
                Surname = "Şirin",
                Adress = "Bilim bahçesi gezgin sk no:8-1",
                BloodType = Models.BloodTypes.ABNegatif,
                BornDate = new DateTime(1996, 7, 3),
                CivilStatus = Models.CivilStatus.Bekar,
                Gender = Models.Gender.Erkek,
                Tel1 = "555-333-22-11",
                Tel2 = "555-333-22-11",
            };
            Models.Patient patient1 = new Models.Patient()
            {
                TCNumber = "44444444444",
                Name = "Mustafa",
                Surname = "Canatar",
                Adress = "Ahmet Ceylan sk no 131",
                BloodType = Models.BloodTypes.BNegatif,
                BornDate = new DateTime(1966, 7, 3),
                CivilStatus = Models.CivilStatus.Bekar,
                Gender = Models.Gender.Erkek,
                Tel1 = "555-333-22-11",
                Tel2 = "555-333-22-11",
            };
            Models.Policlinic devPoliclinic = new Models.Policlinic()
            {
                PoliclinicName = "Bilgi İşlem",
                PoliclinicDetails = "Yazılımcı ve bilgi işlem departmanı",
                isActive = true
            };
            Models.Policlinic docPoliclinic = new Models.Policlinic()
            {
                PoliclinicName = "Aile Hekimi",
                PoliclinicDetails = "Genel Muayene Doktorları Polikliniği",
                isActive = true
            };
            Models.Role rl = new Models.Role()
            {
                RoleName = "Developer",
                RoleDescription = "Yazılımcı Girişi",
                isActive = true
            };
            Models.Role rl2 = new Models.Role()
            {
                RoleName = "Doktor",
                RoleDescription = "Genel Doktor",
                isActive = true
            };
            
            Models.Staff developerStaff = new Models.Staff()
            {
                Name = "Hasan",
                Surname = "Korkmaz",
                EntryDate = new DateTime(2015, 10, 10),
                Adress = "Hacı isa efendi Mh",
                BloodType = Models.BloodTypes.ANegatif,
                BornDate = new DateTime(1997, 1, 6),
                CivilStatus = Models.CivilStatus.Bekar,
                Gender = Models.Gender.Erkek,
                isActive = true,
                Salary = 10000,
                StaffCode = Guid.NewGuid().ToString(),
                Tel1 = "507-575-14-63",
                Tel2 = "507-575-14-62",
                Role = rl,
                Username = "HKORKMAZDEV",
                Password = "12345678",
                Policlinic = devPoliclinic

            };
            Models.Staff doctorStaff = new Models.Staff()
            {
                StaffCode = Guid.NewGuid().ToString(),
                Name = "Tahir",
                Surname = "Sağ",
                Adress = @"Selçuk Üniversitesi Teknoloji Faküktesi No:13\5",
                Tel1 = "555-515-55-55",
                Tel2 = "555-515-55-55",
                BloodType = Models.BloodTypes.SıfırPozitif,
                BornDate = new DateTime(1980, 01, 06),
                isActive = true,
                CivilStatus = Models.CivilStatus.Evli,
                EntryDate = new DateTime(2002, 07, 07),
                Gender = Models.Gender.Erkek,
                Salary = 14000,
                Username = "TAHIRSAG",
                Password = "qwerasdf",
                Policlinic = docPoliclinic,
                Role =rl2
            };
            
           
            Models.PatientDocument patientdoc1 = new Models.PatientDocument()
            {
                PatientDocumentID = "1",
                CreateDocumentDate = new DateTime(1990, 01, 10),
                Patient = patient,
                TCNumber = patient.TCNumber

            };
            Models.PatientDocument patientdoc2 = new Models.PatientDocument()
            {
                PatientDocumentID = "2",
                CreateDocumentDate = new DateTime(1990, 01, 10),
                Patient = patient1,
                TCNumber = patient1.TCNumber

            };
            Models.Transaction tr = new Models.Transaction()
            {
                PatientDocumentID = "1",
                PatientDocument = patientdoc1,
                Piece = 1,
                Price = 10,
                Procces = bloodProcces,
                QueueNumber = 1,
                Staff = doctorStaff,
                ProccesDate = new DateTime(1965, 10, 11),
                StaffCode = doctorStaff.StaffCode,
            };
            Models.Transaction tr2 = new Models.Transaction()
            {
                PatientDocumentID = "1",
                PatientDocument = patientdoc1,
                Piece = 2,
                Price = 15,
                Procces = tahlil2,
                QueueNumber = 2,
                Staff = doctorStaff,
                ProccesDate = new DateTime(1965, 10, 14),
                StaffCode = doctorStaff.StaffCode,
            };
            Models.Transaction tr3 = new Models.Transaction()
            {
                PatientDocumentID = "1",
                PatientDocument = patientdoc1,
                Piece = 3,
                Price = 33,
                Procces = bloodProcces,
                QueueNumber = 2,
                Staff = doctorStaff,
                ProccesDate = new DateTime(1965, 10, 14),
                StaffCode = doctorStaff.StaffCode,
            };
            Models.Transaction tr4 = new Models.Transaction()
            {
                PatientDocumentID = "2",
                PatientDocument = patientdoc2,
                Piece = 1,
                Price = 55,
                Procces = bloodProcces,
                QueueNumber = 1,
                Staff = doctorStaff,
                ProccesDate = new DateTime(1965, 10, 11),
                StaffCode = doctorStaff.StaffCode,
            };
            Models.Transaction tr5 = new Models.Transaction()
            {
                PatientDocumentID = "2",
                PatientDocument = patientdoc2,
                Piece = 2,
                Price = 15,
                Procces = tahlil2,
                QueueNumber = 2,
                Staff = doctorStaff,
                ProccesDate = new DateTime(1965, 10, 14),
                StaffCode = doctorStaff.StaffCode,
            };
            Models.Transaction tr6 = new Models.Transaction()
            {
                PatientDocumentID = "2",
                PatientDocument = patientdoc2,
                Piece = 3,
                Price = 33,
                Procces = bloodProcces,
                QueueNumber = 2,
                Staff = doctorStaff,
                ProccesDate = new DateTime(1965, 10, 14),
                StaffCode = doctorStaff.StaffCode,
            };
            context.Procces.Add(tahlil1);
            context.Procces.Add(tahlil2);
            context.Procces.Add(firstLook);
            context.Procces.Add(bloodProcces);
            context.Patients.Add(patient);
            context.Patients.Add(patient1);
            context.PatientDocument.Add(patientdoc1);
            context.PatientDocument.Add(patientdoc2);
            context.Policlinic.Add(docPoliclinic);
            context.Policlinic.Add(devPoliclinic);
            context.Role.Add(rl2);
            context.Role.Add(rl);
            context.Staff.Add(doctorStaff);
            context.Staff.Add(developerStaff);
            context.Transaction.Add(tr);
            context.Transaction.Add(tr2);
            context.Transaction.Add(tr3);
            context.Transaction.Add(tr4);
            context.Transaction.Add(tr5);
            context.Transaction.Add(tr6);
            context.SaveChanges();
            base.Seed(context);
        }
    }

}
