using System;
using System.Windows.Forms;
using Tyuiu.GaberkornEL.Sprint7.Project.V6.Lib;

namespace Tyuiu.GaberkornEL.Sprint7.Project.V6
{
    public partial class FormAddEditPatient : Form
    {
        private DataService dataService_GEL;
        private Patient currentPatient_GEL; 
        private bool isEditMode_GEL;

        public FormAddEditPatient(DataService ds, Patient patient)
        {
            InitializeComponent();
            dataService_GEL = ds;
            currentPatient_GEL = patient ?? new Patient();
            isEditMode_GEL = patient != null;

            if (isEditMode_GEL)
            {
                textBoxFam_GEL.Text = currentPatient_GEL.Fam;
                textBoxIm_GEL.Text = currentPatient_GEL.Im;
                textBoxOtch_GEL.Text = currentPatient_GEL.Otch;
                textBoxDateBirth_GEL.Text = currentPatient_GEL.DateBirth;
                textBoxDoctor_GEL.Text = currentPatient_GEL.Doctor;
                textBoxSpec_GEL.Text = currentPatient_GEL.Spec;
                textBoxDiag_GEL.Text = currentPatient_GEL.Diag;
                comboBoxAmbul_GEL.SelectedItem = currentPatient_GEL.Ambul;
                textBoxDays_GEL.Text = currentPatient_GEL.Days.ToString();
                comboBoxDisp_GEL.SelectedItem = currentPatient_GEL.Disp;
                textBoxPrim_GEL.Text = currentPatient_GEL.Prim;
            }
        }

        private void buttonSavePatient_GEL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFam_GEL.Text) ||
                string.IsNullOrWhiteSpace(textBoxIm_GEL.Text) ||
                !int.TryParse(textBoxDays_GEL.Text, out int days) || days < 0)
            {
                MessageBox.Show("Заполните обязательные поля (*) корректно!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentPatient_GEL.Fam = textBoxFam_GEL.Text.Trim();
            currentPatient_GEL.Im = textBoxIm_GEL.Text.Trim();
            currentPatient_GEL.Otch = textBoxOtch_GEL.Text.Trim();
            currentPatient_GEL.DateBirth = textBoxDateBirth_GEL.Text.Trim();
            currentPatient_GEL.Doctor = textBoxDoctor_GEL.Text.Trim();
            currentPatient_GEL.Spec = textBoxSpec_GEL.Text.Trim();
            currentPatient_GEL.Diag = textBoxDiag_GEL.Text.Trim();
            currentPatient_GEL.Ambul = comboBoxAmbul_GEL.SelectedItem?.ToString() ?? "Нет";
            currentPatient_GEL.Days = days;
            currentPatient_GEL.Disp = comboBoxDisp_GEL.SelectedItem?.ToString() ?? "Нет";
            currentPatient_GEL.Prim = textBoxPrim_GEL.Text.Trim();

            if (!isEditMode_GEL)
            {
                dataService_GEL.AddPatient(currentPatient_GEL);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_GEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}