namespace Tyuiu.GaberkornEL.Sprint7.Project.V6
{
    partial class FormAddEditPatient
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxPatient_GEL = new GroupBox();
            labelFam_GEL = new Label();
            textBoxFam_GEL = new TextBox();
            labelIm_GEL = new Label();
            textBoxIm_GEL = new TextBox();
            labelOtch_GEL = new Label();
            textBoxOtch_GEL = new TextBox();
            labelDateBirth_GEL = new Label();
            textBoxDateBirth_GEL = new TextBox();
            labelDoctor_GEL = new Label();
            textBoxDoctor_GEL = new TextBox();
            labelSpec_GEL = new Label();
            textBoxSpec_GEL = new TextBox();
            labelDiag_GEL = new Label();
            textBoxDiag_GEL = new TextBox();
            labelAmbul_GEL = new Label();
            comboBoxAmbul_GEL = new ComboBox();
            labelDays_GEL = new Label();
            textBoxDays_GEL = new TextBox();
            labelDisp_GEL = new Label();
            comboBoxDisp_GEL = new ComboBox();
            labelPrim_GEL = new Label();
            textBoxPrim_GEL = new TextBox();
            buttonSavePatient_GEL = new Button();
            buttonCancel_GEL = new Button();
            groupBoxPatient_GEL.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPatient_GEL
            // 
            groupBoxPatient_GEL.Controls.Add(labelFam_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxFam_GEL);
            groupBoxPatient_GEL.Controls.Add(labelIm_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxIm_GEL);
            groupBoxPatient_GEL.Controls.Add(labelOtch_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxOtch_GEL);
            groupBoxPatient_GEL.Controls.Add(labelDateBirth_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxDateBirth_GEL);
            groupBoxPatient_GEL.Controls.Add(labelDoctor_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxDoctor_GEL);
            groupBoxPatient_GEL.Controls.Add(labelSpec_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxSpec_GEL);
            groupBoxPatient_GEL.Controls.Add(labelDiag_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxDiag_GEL);
            groupBoxPatient_GEL.Controls.Add(labelAmbul_GEL);
            groupBoxPatient_GEL.Controls.Add(comboBoxAmbul_GEL);
            groupBoxPatient_GEL.Controls.Add(labelDays_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxDays_GEL);
            groupBoxPatient_GEL.Controls.Add(labelDisp_GEL);
            groupBoxPatient_GEL.Controls.Add(comboBoxDisp_GEL);
            groupBoxPatient_GEL.Controls.Add(labelPrim_GEL);
            groupBoxPatient_GEL.Controls.Add(textBoxPrim_GEL);
            groupBoxPatient_GEL.Location = new Point(12, 12);
            groupBoxPatient_GEL.Name = "groupBoxPatient_GEL";
            groupBoxPatient_GEL.Size = new Size(580, 640);
            groupBoxPatient_GEL.TabIndex = 0;
            groupBoxPatient_GEL.TabStop = false;
            groupBoxPatient_GEL.Text = "Данные пациента";
            // 
            // labelFam_GEL
            // 
            labelFam_GEL.AutoSize = true;
            labelFam_GEL.Location = new Point(20, 30);
            labelFam_GEL.Name = "labelFam_GEL";
            labelFam_GEL.Size = new Size(82, 20);
            labelFam_GEL.TabIndex = 0;
            labelFam_GEL.Text = "Фамилия:*";
            // 
            // textBoxFam_GEL
            // 
            textBoxFam_GEL.Location = new Point(160, 25);
            textBoxFam_GEL.Name = "textBoxFam_GEL";
            textBoxFam_GEL.Size = new Size(380, 27);
            textBoxFam_GEL.TabIndex = 1;
            // 
            // labelIm_GEL
            // 
            labelIm_GEL.AutoSize = true;
            labelIm_GEL.Location = new Point(20, 80);
            labelIm_GEL.Name = "labelIm_GEL";
            labelIm_GEL.Size = new Size(48, 20);
            labelIm_GEL.TabIndex = 2;
            labelIm_GEL.Text = "Имя:*";
            // 
            // textBoxIm_GEL
            // 
            textBoxIm_GEL.Location = new Point(160, 75);
            textBoxIm_GEL.Name = "textBoxIm_GEL";
            textBoxIm_GEL.Size = new Size(380, 27);
            textBoxIm_GEL.TabIndex = 3;
            // 
            // labelOtch_GEL
            // 
            labelOtch_GEL.AutoSize = true;
            labelOtch_GEL.Location = new Point(20, 130);
            labelOtch_GEL.Name = "labelOtch_GEL";
            labelOtch_GEL.Size = new Size(75, 20);
            labelOtch_GEL.TabIndex = 4;
            labelOtch_GEL.Text = "Отчество:";
            // 
            // textBoxOtch_GEL
            // 
            textBoxOtch_GEL.Location = new Point(160, 125);
            textBoxOtch_GEL.Name = "textBoxOtch_GEL";
            textBoxOtch_GEL.Size = new Size(380, 27);
            textBoxOtch_GEL.TabIndex = 5;
            // 
            // labelDateBirth_GEL
            // 
            labelDateBirth_GEL.AutoSize = true;
            labelDateBirth_GEL.Location = new Point(20, 180);
            labelDateBirth_GEL.Name = "labelDateBirth_GEL";
            labelDateBirth_GEL.Size = new Size(201, 20);
            labelDateBirth_GEL.TabIndex = 6;
            labelDateBirth_GEL.Text = "Дата рождения (дд.мм.гггг):";
            // 
            // textBoxDateBirth_GEL
            // 
            textBoxDateBirth_GEL.Location = new Point(218, 177);
            textBoxDateBirth_GEL.Name = "textBoxDateBirth_GEL";
            textBoxDateBirth_GEL.Size = new Size(322, 27);
            textBoxDateBirth_GEL.TabIndex = 7;
            // 
            // labelDoctor_GEL
            // 
            labelDoctor_GEL.AutoSize = true;
            labelDoctor_GEL.Location = new Point(20, 230);
            labelDoctor_GEL.Name = "labelDoctor_GEL";
            labelDoctor_GEL.Size = new Size(46, 20);
            labelDoctor_GEL.TabIndex = 8;
            labelDoctor_GEL.Text = "Врач:";
            // 
            // textBoxDoctor_GEL
            // 
            textBoxDoctor_GEL.Location = new Point(160, 225);
            textBoxDoctor_GEL.Name = "textBoxDoctor_GEL";
            textBoxDoctor_GEL.Size = new Size(380, 27);
            textBoxDoctor_GEL.TabIndex = 9;
            // 
            // labelSpec_GEL
            // 
            labelSpec_GEL.AutoSize = true;
            labelSpec_GEL.Location = new Point(20, 280);
            labelSpec_GEL.Name = "labelSpec_GEL";
            labelSpec_GEL.Size = new Size(122, 20);
            labelSpec_GEL.TabIndex = 10;
            labelSpec_GEL.Text = "Специализация:";
            // 
            // textBoxSpec_GEL
            // 
            textBoxSpec_GEL.Location = new Point(160, 275);
            textBoxSpec_GEL.Name = "textBoxSpec_GEL";
            textBoxSpec_GEL.Size = new Size(380, 27);
            textBoxSpec_GEL.TabIndex = 11;
            // 
            // labelDiag_GEL
            // 
            labelDiag_GEL.AutoSize = true;
            labelDiag_GEL.Location = new Point(20, 330);
            labelDiag_GEL.Name = "labelDiag_GEL";
            labelDiag_GEL.Size = new Size(70, 20);
            labelDiag_GEL.TabIndex = 12;
            labelDiag_GEL.Text = "Диагноз:";
            // 
            // textBoxDiag_GEL
            // 
            textBoxDiag_GEL.Location = new Point(160, 325);
            textBoxDiag_GEL.Name = "textBoxDiag_GEL";
            textBoxDiag_GEL.Size = new Size(380, 27);
            textBoxDiag_GEL.TabIndex = 13;
            // 
            // labelAmbul_GEL
            // 
            labelAmbul_GEL.AutoSize = true;
            labelAmbul_GEL.Location = new Point(20, 380);
            labelAmbul_GEL.Name = "labelAmbul_GEL";
            labelAmbul_GEL.Size = new Size(107, 20);
            labelAmbul_GEL.TabIndex = 14;
            labelAmbul_GEL.Text = "Амбулаторно:";
            // 
            // comboBoxAmbul_GEL
            // 
            comboBoxAmbul_GEL.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAmbul_GEL.Items.AddRange(new object[] { "Да", "Нет" });
            comboBoxAmbul_GEL.Location = new Point(160, 375);
            comboBoxAmbul_GEL.Name = "comboBoxAmbul_GEL";
            comboBoxAmbul_GEL.Size = new Size(121, 28);
            comboBoxAmbul_GEL.TabIndex = 15;
            // 
            // labelDays_GEL
            // 
            labelDays_GEL.AutoSize = true;
            labelDays_GEL.Location = new Point(20, 430);
            labelDays_GEL.Name = "labelDays_GEL";
            labelDays_GEL.Size = new Size(196, 20);
            labelDays_GEL.TabIndex = 16;
            labelDays_GEL.Text = "Дни нетрудоспособности:*";
            // 
            // textBoxDays_GEL
            // 
            textBoxDays_GEL.Location = new Point(218, 427);
            textBoxDays_GEL.Name = "textBoxDays_GEL";
            textBoxDays_GEL.Size = new Size(150, 27);
            textBoxDays_GEL.TabIndex = 17;
            // 
            // labelDisp_GEL
            // 
            labelDisp_GEL.AutoSize = true;
            labelDisp_GEL.Location = new Point(20, 480);
            labelDisp_GEL.Name = "labelDisp_GEL";
            labelDisp_GEL.Size = new Size(150, 20);
            labelDisp_GEL.TabIndex = 18;
            labelDisp_GEL.Text = "Диспансерный учет:";
            // 
            // comboBoxDisp_GEL
            // 
            comboBoxDisp_GEL.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDisp_GEL.Items.AddRange(new object[] { "Да", "Нет" });
            comboBoxDisp_GEL.Location = new Point(176, 477);
            comboBoxDisp_GEL.Name = "comboBoxDisp_GEL";
            comboBoxDisp_GEL.Size = new Size(121, 28);
            comboBoxDisp_GEL.TabIndex = 19;
            // 
            // labelPrim_GEL
            // 
            labelPrim_GEL.AutoSize = true;
            labelPrim_GEL.Location = new Point(20, 530);
            labelPrim_GEL.Name = "labelPrim_GEL";
            labelPrim_GEL.Size = new Size(102, 20);
            labelPrim_GEL.TabIndex = 20;
            labelPrim_GEL.Text = "Примечание:";
            // 
            // textBoxPrim_GEL
            // 
            textBoxPrim_GEL.Location = new Point(160, 525);
            textBoxPrim_GEL.Multiline = true;
            textBoxPrim_GEL.Name = "textBoxPrim_GEL";
            textBoxPrim_GEL.Size = new Size(380, 100);
            textBoxPrim_GEL.TabIndex = 21;
            // 
            // buttonSavePatient_GEL
            // 
            buttonSavePatient_GEL.Location = new Point(160, 670);
            buttonSavePatient_GEL.Name = "buttonSavePatient_GEL";
            buttonSavePatient_GEL.Size = new Size(120, 40);
            buttonSavePatient_GEL.TabIndex = 1;
            buttonSavePatient_GEL.Text = "Сохранить";
            buttonSavePatient_GEL.Click += buttonSavePatient_GEL_Click;
            // 
            // buttonCancel_GEL
            // 
            buttonCancel_GEL.Location = new Point(300, 670);
            buttonCancel_GEL.Name = "buttonCancel_GEL";
            buttonCancel_GEL.Size = new Size(120, 40);
            buttonCancel_GEL.TabIndex = 2;
            buttonCancel_GEL.Text = "Отмена";
            buttonCancel_GEL.Click += buttonCancel_GEL_Click;
            // 
            // FormAddEditPatient
            // 
            AcceptButton = buttonSavePatient_GEL;
            CancelButton = buttonCancel_GEL;
            ClientSize = new Size(602, 713);
            Controls.Add(groupBoxPatient_GEL);
            Controls.Add(buttonSavePatient_GEL);
            Controls.Add(buttonCancel_GEL);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddEditPatient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление / редактирование пациента - Габеркорн Е.Л.";
            groupBoxPatient_GEL.ResumeLayout(false);
            groupBoxPatient_GEL.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox groupBoxPatient_GEL;

        private Label labelFam_GEL;
        private TextBox textBoxFam_GEL;
        private Label labelIm_GEL;
        private TextBox textBoxIm_GEL;
        private Label labelOtch_GEL;
        private TextBox textBoxOtch_GEL;
        private Label labelDateBirth_GEL;
        private TextBox textBoxDateBirth_GEL;
        private Label labelDoctor_GEL;
        private TextBox textBoxDoctor_GEL;
        private Label labelSpec_GEL;
        private TextBox textBoxSpec_GEL;
        private Label labelDiag_GEL;
        private TextBox textBoxDiag_GEL;
        private Label labelAmbul_GEL;
        private ComboBox comboBoxAmbul_GEL;
        private Label labelDays_GEL;
        private TextBox textBoxDays_GEL;
        private Label labelDisp_GEL;
        private ComboBox comboBoxDisp_GEL;
        private Label labelPrim_GEL;
        private TextBox textBoxPrim_GEL;

        private Button buttonSavePatient_GEL;
        private Button buttonCancel_GEL;
    }
}