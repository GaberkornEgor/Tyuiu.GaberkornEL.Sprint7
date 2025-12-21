using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.GaberkornEL.Sprint7.Project.V6.Lib;

namespace Tyuiu.GaberkornEL.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService ds;
        private const string TestFileName = "patients.csv";

        [TestInitialize]
        public void Setup()
        {
            ds = new DataService();
            ds.pats.Clear();

            if (File.Exists(TestFileName))
                File.Delete(TestFileName);
        }

        [TestMethod]
        public void Test_AddPatient_GeneratesCorrectId()
        {
            Patient p1 = new Patient { Fam = "Иванов", Im = "Иван", Days = 5, Ambul = "Да" };
            Patient p2 = new Patient { Fam = "Петров", Im = "Пётр", Days = 10, Ambul = "Нет" };

            ds.AddPatient(p1);
            ds.AddPatient(p2);

            Assert.AreEqual(1, p1.Id);
            Assert.AreEqual(2, p2.Id);
            Assert.AreEqual(2, ds.GetCount());
        }

        [TestMethod]
        public void Test_SaveAndLoad_Roundtrip_WorksCorrectly()
        {
            Patient p = new Patient
            {
                Fam = "Габеркорн",
                Im = "Егор",
                Otch = "Леонидович",
                DateBirth = "04.10.2007",
                Doctor = "Спиридонов А.А.",
                Spec = "Терапевт",
                Diag = "ОРВИ",
                Ambul = "Да",
                Days = 7,
                Disp = "Нет",
                Prim = "Температура 38.2"
            };

            ds.AddPatient(p);
            ds.SaveData(); 

            DataService dsNew = new DataService();
            dsNew.LoadData();

            Assert.AreEqual(1, dsNew.pats.Count);
            Patient loaded = dsNew.pats[0];

            Assert.AreEqual("Габеркорн", loaded.Fam);
            Assert.AreEqual("Егор", loaded.Im);
            Assert.AreEqual("ОРВИ", loaded.Diag);
            Assert.AreEqual("Да", loaded.Ambul);
            Assert.AreEqual(7, loaded.Days);
            Assert.AreEqual("Температура 38.2", loaded.Prim);
        }

        [TestMethod]
        public void Test_Statistics_CalculatesCorrectly()
        {
            ds.AddPatient(new Patient { Days = 3, Ambul = "Да" });
            ds.AddPatient(new Patient { Days = 7, Ambul = "Нет" });
            ds.AddPatient(new Patient { Days = 14, Ambul = "Да" });

            Assert.AreEqual(3, ds.GetCount());
            Assert.AreEqual(24, ds.GetSumDays());
            Assert.AreEqual(8.0, ds.GetAvgDays());
            Assert.AreEqual(2, ds.GetAmbulYes());
        }

        [TestMethod]
        public void Test_Search_FindsCorrectPatients()
        {
            ds.AddPatient(new Patient { Fam = "Иванов", Diag = "Грипп", Doctor = "Петров" });
            ds.AddPatient(new Patient { Fam = "Сидоров", Diag = "ОРВИ", Doctor = "Иванов" });
            ds.AddPatient(new Patient { Fam = "Козлов", Diag = "Ангина", Doctor = "Спиридонов" });

            var result1 = ds.Search("иван");
            Assert.AreEqual(2, result1.Count);

            var result2 = ds.Search("грипп");
            Assert.AreEqual(1, result2.Count);
            Assert.AreEqual("Иванов", result2[0].Fam);

            var result3 = ds.Search("несуществующий");
            Assert.AreEqual(0, result3.Count);
        }

        [TestMethod]
        public void Test_DeletePatient_RemovesCorrectly()
        {
            Patient p1 = new Patient { Fam = "Первый" };
            Patient p2 = new Patient { Fam = "Второй" };
            Patient p3 = new Patient { Fam = "Третий" };

            ds.AddPatient(p1);
            ds.AddPatient(p2);
            ds.AddPatient(p3);

            ds.DeletePatient(p2.Id);

            Assert.AreEqual(2, ds.GetCount());
            Assert.IsTrue(ds.pats.Exists(x => x.Fam == "Первый"));
            Assert.IsFalse(ds.pats.Exists(x => x.Fam == "Второй"));
            Assert.IsTrue(ds.pats.Exists(x => x.Fam == "Третий"));
        }

        [TestMethod]
        public void Test_EmptyList_Statistics_ReturnZero()
        {
            Assert.AreEqual(0, ds.GetCount());
            Assert.AreEqual(0, ds.GetSumDays());
            Assert.AreEqual(0.0, ds.GetAvgDays());
            Assert.AreEqual(0, ds.GetAmbulYes());
        }
    }
}