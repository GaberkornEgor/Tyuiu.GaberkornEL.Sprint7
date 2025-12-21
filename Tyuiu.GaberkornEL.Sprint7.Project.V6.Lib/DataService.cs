using System;
using System.Collections.Generic;
using System.IO;

namespace Tyuiu.GaberkornEL.Sprint7.Project.V6.Lib
{
    public class Patient
    {
        public int Id { get; set; }
        public string Fam { get; set; } = "";        // Фамилия
        public string Im { get; set; } = "";         // Имя
        public string Otch { get; set; } = "";       // Отчество
        public string DateBirth { get; set; } = "";  // Дата рождения 
        public string Doctor { get; set; } = "";     // ФИО врача
        public string Spec { get; set; } = "";       // Специализация
        public string Diag { get; set; } = "";       // Диагноз
        public string Ambul { get; set; } = "Нет";   // Амбулаторно 
        public int Days { get; set; }                // Дни нетрудоспособности
        public string Disp { get; set; } = "Нет";    // Диспансерный учет
        public string Prim { get; set; } = "";       // Примечание
    }

    public class DataService
    {
        public List<Patient> pats = new List<Patient>(); // список пациентов
        private string file = "patients.csv"; 

        // Загрузить из файла
        public void LoadData()
        {
            pats.Clear();
            if (!File.Exists(file)) return; // если файла нет то ничего

            string[] lines = File.ReadAllLines(file);
            for (int i = 1; i < lines.Length; i++) //  заголовок
            {
                string line = lines[i];
                if (line == "") continue;

                string[] d = line.Split(';');
                Patient p = new Patient();
                p.Id = int.Parse(d[0]);
                p.Fam = d[1];
                p.Im = d[2];
                p.Otch = d[3];
                p.DateBirth = d[4];
                p.Doctor = d[5];
                p.Spec = d[6];
                p.Diag = d[7];
                p.Ambul = d[8];
                p.Days = int.Parse(d[9]);
                p.Disp = d[10];
                p.Prim = d[11];

                pats.Add(p);
            }
        }

        // Сохранение в файл
        public void SaveData()
        {
            List<string> lines = new List<string>();
            lines.Add("Id;Фамилия;Имя;Отчество;Дата рождения;Врач;Специализация;Диагноз;Амбулаторно;Дни;Диспансер;Примечание");

            foreach (Patient p in pats)
            {
                string line = $"{p.Id};{p.Fam};{p.Im};{p.Otch};{p.DateBirth};{p.Doctor};{p.Spec};{p.Diag};{p.Ambul};{p.Days};{p.Disp};{p.Prim}";
                lines.Add(line);
            }

            File.WriteAllLines(file, lines);
        }

        // Добавление нового пациента
        public void AddPatient(Patient p)
        {
            int newId = 1;
            if (pats.Count > 0)
            {
                foreach (Patient pp in pats)
                {
                    if (pp.Id >= newId) newId = pp.Id + 1;
                }
            }
            p.Id = newId;
            pats.Add(p);
        }

        // Удаление по Айдишнику
        public void DeletePatient(int id)
        {
            for (int i = 0; i < pats.Count; i++)
            {
                if (pats[i].Id == id)
                {
                    pats.RemoveAt(i);
                    break;
                }
            }
        }

        // Поиск по строке (Фамилии, диагнозу, врачу)
        public List<Patient> Search(string text)
        {
            List<Patient> result = new List<Patient>();
            text = text.ToLower();
            foreach (Patient p in pats)
            {
                if (p.Fam.ToLower().Contains(text) ||
                    p.Diag.ToLower().Contains(text) ||
                    p.Doctor.ToLower().Contains(text))
                {
                    result.Add(p);
                }
            }
            return result;
        }

        // Стата
        public int GetCount() { return pats.Count; }

        public int GetSumDays()
        {
            int s = 0;
            foreach (Patient p in pats) s += p.Days;
            return s;
        }

        public double GetAvgDays()
        {
            if (pats.Count == 0) return 0;
            return (double)GetSumDays() / pats.Count;
        }

        public int GetAmbulYes()
        {
            int c = 0;
            foreach (Patient p in pats)
                if (p.Ambul == "Да") c++;
            return c;
        }
    }
}