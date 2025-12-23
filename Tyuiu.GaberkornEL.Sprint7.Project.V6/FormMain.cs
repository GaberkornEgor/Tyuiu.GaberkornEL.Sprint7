using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyuiu.GaberkornEL.Sprint7.Project.V6.Lib;

namespace Tyuiu.GaberkornEL.Sprint7.Project.V6
{
    public partial class FormMain : Form
    {
        private List<Patient> currentPatientsList_GEL = new List<Patient>();
        private DataService dataService_GEL = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadPatientsToGrid_GEL();
        }

        private void LoadPatientsToGrid_GEL()
        {
            dataService_GEL.LoadData();
            currentPatientsList_GEL = new List<Patient>(dataService_GEL.pats);
            dataGridViewPatients_GEL.DataSource = currentPatientsList_GEL;
            UpdateStatistics_GEL();
        }

        private void UpdateStatistics_GEL()
        {
            labelCountValue_GEL.Text = dataService_GEL.GetCount().ToString();
            labelSumDaysValue_GEL.Text = dataService_GEL.GetSumDays().ToString();
            labelAvgDaysValue_GEL.Text = dataService_GEL.GetAvgDays().ToString("F2");
            labelAmbulYesValue_GEL.Text = dataService_GEL.GetAmbulYes().ToString();
        }

        private void buttonSearchExecute_GEL_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_GEL.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                currentPatientsList_GEL = new List<Patient>(dataService_GEL.pats);
            }
            else
            {
                currentPatientsList_GEL = dataService_GEL.Search(searchText);
            }

            dataGridViewPatients_GEL.DataSource = currentPatientsList_GEL;
        }

        private void toolStripButtonAddPatient_GEL_Click(object sender, EventArgs e)
        {
            OpenAddEditForm_GEL(null);
        }

        private void toolStripButtonEditPatient_GEL_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients_GEL.SelectedRows.Count > 0)
            {
                Patient selected = dataGridViewPatients_GEL.SelectedRows[0].DataBoundItem as Patient;
                OpenAddEditForm_GEL(selected);
            }
            else
            {
                MessageBox.Show("Выберите пациента для редактирования.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewPatients_GEL_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewPatients_GEL.SelectedRows.Count > 0)
            {
                toolStripButtonEditPatient_GEL_Click(sender, e);
            }
        }

        private void OpenAddEditForm_GEL(Patient patient)
        {
            FormAddEditPatient form = new FormAddEditPatient(dataService_GEL, patient);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataService_GEL.SaveData();
                LoadPatientsToGrid_GEL();
            }
        }

        private void toolStripButtonDeletePatient_GEL_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients_GEL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пациента для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Удалить выбранного пациента?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dataGridViewPatients_GEL.SelectedRows[0].Cells["columnId_GEL"].Value;
                dataService_GEL.DeletePatient(id);
                dataService_GEL.SaveData();
                LoadPatientsToGrid_GEL();
            }
        }

        private void toolStripButtonRefresh_GEL_Click(object sender, EventArgs e)
        {
            LoadPatientsToGrid_GEL();
        }

        private void toolStripButtonStats_GEL_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Количество пациентов: {labelCountValue_GEL.Text}\n" +
                $"Сумма дней нетрудоспособности: {labelSumDaysValue_GEL.Text}\n" +
                $"Среднее количество дней: {labelAvgDaysValue_GEL.Text}\n" +
                $"Амбулаторное лечение (Да): {labelAmbulYesValue_GEL.Text}",
                "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonSave_GEL_Click(object sender, EventArgs e)
        {
            dataService_GEL.SaveData();
            MessageBox.Show("Данные сохранены в файл patients.csv", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItemAddPatient_GEL_Click(object sender, EventArgs e) => toolStripButtonAddPatient_GEL_Click(sender, e);
        private void toolStripMenuItemEditPatient_GEL_Click(object sender, EventArgs e) => toolStripButtonEditPatient_GEL_Click(sender, e);
        private void toolStripMenuItemDeletePatient_GEL_Click(object sender, EventArgs e) => toolStripButtonDeletePatient_GEL_Click(sender, e);
        private void toolStripMenuItemShowStats_GEL_Click(object sender, EventArgs e) => toolStripButtonStats_GEL_Click(sender, e);
        private void toolStripMenuItemSave_GEL_Click(object sender, EventArgs e) => toolStripButtonSave_GEL_Click(sender, e);

        private void toolStripMenuItemAbout_GEL_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemGuide_GEL_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void toolStripMenuItemExit_GEL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonSearch_GEL_Click(object sender, EventArgs e)
        {

        }
    }
}