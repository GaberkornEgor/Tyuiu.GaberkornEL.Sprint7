namespace Tyuiu.GaberkornEL.Sprint7.Project.V6
{
    partial class FormMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();

            this.mainMenuStripPolyclinic_GEL = new MenuStrip();
            this.toolStripMenuItemFile_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemSave_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemExit_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemPatient_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemAddPatient_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemEditPatient_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemDeletePatient_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemHelp_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemAbout_GEL = new ToolStripMenuItem();
            this.toolStripMenuItemGuide_GEL = new ToolStripMenuItem();

            this.toolStripMain_GEL = new ToolStrip();
            this.toolStripButtonAddPatient_GEL = new ToolStripButton();
            this.toolStripButtonEditPatient_GEL = new ToolStripButton();
            this.toolStripButtonDeletePatient_GEL = new ToolStripButton();
            this.toolStripButtonSearch_GEL = new ToolStripButton();
            this.toolStripButtonRefresh_GEL = new ToolStripButton();
            this.toolStripButtonSave_GEL = new ToolStripButton();

            this.panelSearch_GEL = new Panel();
            this.buttonSearchExecute_GEL = new Button();
            this.textBoxSearch_GEL = new TextBox();
            this.labelSearch_GEL = new Label();

            this.dataGridViewPatients_GEL = new DataGridView();

            this.groupBoxStats_GEL = new GroupBox();
            this.labelCount_GEL = new Label();
            this.labelCountValue_GEL = new Label();
            this.labelSumDays_GEL = new Label();
            this.labelSumDaysValue_GEL = new Label();
            this.labelAvgDays_GEL = new Label();
            this.labelAvgDaysValue_GEL = new Label();
            this.labelAmbulYes_GEL = new Label();
            this.labelAmbulYesValue_GEL = new Label();

            this.mainMenuStripPolyclinic_GEL.SuspendLayout();
            this.toolStripMain_GEL.SuspendLayout();
            this.panelSearch_GEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_GEL)).BeginInit();
            this.groupBoxStats_GEL.SuspendLayout();
            this.SuspendLayout();

            // mainMenuStripPolyclinic_GEL
            this.mainMenuStripPolyclinic_GEL.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStripPolyclinic_GEL.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItemFile_GEL, this.toolStripMenuItemPatient_GEL, this.toolStripMenuItemHelp_GEL });
            this.mainMenuStripPolyclinic_GEL.Location = new System.Drawing.Point(0, 77);
            this.mainMenuStripPolyclinic_GEL.Name = "mainMenuStripPolyclinic_GEL";
            this.mainMenuStripPolyclinic_GEL.Size = new System.Drawing.Size(1200, 28);
            this.mainMenuStripPolyclinic_GEL.TabIndex = 0;

            // toolStripMenuItemFile_GEL
            this.toolStripMenuItemFile_GEL.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItemSave_GEL, this.toolStripMenuItemExit_GEL });
            this.toolStripMenuItemFile_GEL.Name = "toolStripMenuItemFile_GEL";
            this.toolStripMenuItemFile_GEL.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItemFile_GEL.Text = "Файл";

            this.toolStripMenuItemSave_GEL.Name = "toolStripMenuItemSave_GEL";
            this.toolStripMenuItemSave_GEL.Size = new System.Drawing.Size(166, 26);
            this.toolStripMenuItemSave_GEL.Text = "Сохранить";
            this.toolStripMenuItemSave_GEL.Click += new System.EventHandler(this.toolStripMenuItemSave_GEL_Click);

            this.toolStripMenuItemExit_GEL.Name = "toolStripMenuItemExit_GEL";
            this.toolStripMenuItemExit_GEL.Size = new System.Drawing.Size(166, 26);
            this.toolStripMenuItemExit_GEL.Text = "Выход";
            this.toolStripMenuItemExit_GEL.Click += new System.EventHandler(this.toolStripMenuItemExit_GEL_Click);

            // toolStripMenuItemPatient_GEL
            this.toolStripMenuItemPatient_GEL.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItemAddPatient_GEL, this.toolStripMenuItemEditPatient_GEL, this.toolStripMenuItemDeletePatient_GEL });
            this.toolStripMenuItemPatient_GEL.Name = "toolStripMenuItemPatient_GEL";
            this.toolStripMenuItemPatient_GEL.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItemPatient_GEL.Text = "Пациент";

            this.toolStripMenuItemAddPatient_GEL.Name = "toolStripMenuItemAddPatient_GEL";
            this.toolStripMenuItemAddPatient_GEL.Size = new System.Drawing.Size(194, 26);
            this.toolStripMenuItemAddPatient_GEL.Text = "Добавить";
            this.toolStripMenuItemAddPatient_GEL.Click += new System.EventHandler(this.toolStripMenuItemAddPatient_GEL_Click);

            this.toolStripMenuItemEditPatient_GEL.Name = "toolStripMenuItemEditPatient_GEL";
            this.toolStripMenuItemEditPatient_GEL.Size = new System.Drawing.Size(194, 26);
            this.toolStripMenuItemEditPatient_GEL.Text = "Редактировать";
            this.toolStripMenuItemEditPatient_GEL.Click += new System.EventHandler(this.toolStripMenuItemEditPatient_GEL_Click);

            this.toolStripMenuItemDeletePatient_GEL.Name = "toolStripMenuItemDeletePatient_GEL";
            this.toolStripMenuItemDeletePatient_GEL.Size = new System.Drawing.Size(194, 26);
            this.toolStripMenuItemDeletePatient_GEL.Text = "Удалить";
            this.toolStripMenuItemDeletePatient_GEL.Click += new System.EventHandler(this.toolStripMenuItemDeletePatient_GEL_Click);

            // toolStripMenuItemHelp_GEL
            this.toolStripMenuItemHelp_GEL.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItemAbout_GEL, this.toolStripMenuItemGuide_GEL });
            this.toolStripMenuItemHelp_GEL.Name = "toolStripMenuItemHelp_GEL";
            this.toolStripMenuItemHelp_GEL.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItemHelp_GEL.Text = "Справка";

            this.toolStripMenuItemAbout_GEL.Name = "toolStripMenuItemAbout_GEL";
            this.toolStripMenuItemAbout_GEL.Size = new System.Drawing.Size(278, 26);
            this.toolStripMenuItemAbout_GEL.Text = "О программе";
            this.toolStripMenuItemAbout_GEL.Click += new System.EventHandler(this.toolStripMenuItemAbout_GEL_Click);

            this.toolStripMenuItemGuide_GEL.Name = "toolStripMenuItemGuide_GEL";
            this.toolStripMenuItemGuide_GEL.Size = new System.Drawing.Size(278, 26);
            this.toolStripMenuItemGuide_GEL.Text = "Руководство пользователя";
            this.toolStripMenuItemGuide_GEL.Click += new System.EventHandler(this.toolStripMenuItemGuide_GEL_Click);

            // toolStripMain_GEL
            this.toolStripMain_GEL.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain_GEL.Items.AddRange(new ToolStripItem[] { this.toolStripButtonAddPatient_GEL, this.toolStripButtonEditPatient_GEL, this.toolStripButtonDeletePatient_GEL, this.toolStripButtonRefresh_GEL, this.toolStripButtonSave_GEL, this.toolStripButtonSearch_GEL });
            this.toolStripMain_GEL.Location = new System.Drawing.Point(0, 50);
            this.toolStripMain_GEL.Name = "toolStripMain_GEL";
            this.toolStripMain_GEL.Size = new System.Drawing.Size(1200, 27);
            this.toolStripMain_GEL.TabIndex = 1;

            this.toolStripButtonAddPatient_GEL.Name = "toolStripButtonAddPatient_GEL";
            this.toolStripButtonAddPatient_GEL.Size = new System.Drawing.Size(80, 24);
            this.toolStripButtonAddPatient_GEL.Text = "Добавить";
            this.toolStripButtonAddPatient_GEL.Click += new System.EventHandler(this.toolStripButtonAddPatient_GEL_Click);

            this.toolStripButtonEditPatient_GEL.Name = "toolStripButtonEditPatient_GEL";
            this.toolStripButtonEditPatient_GEL.Size = new System.Drawing.Size(115, 24);
            this.toolStripButtonEditPatient_GEL.Text = "Редактировать";
            this.toolStripButtonEditPatient_GEL.Click += new System.EventHandler(this.toolStripButtonEditPatient_GEL_Click);

            this.toolStripButtonDeletePatient_GEL.Name = "toolStripButtonDeletePatient_GEL";
            this.toolStripButtonDeletePatient_GEL.Size = new System.Drawing.Size(69, 24);
            this.toolStripButtonDeletePatient_GEL.Text = "Удалить";
            this.toolStripButtonDeletePatient_GEL.Click += new System.EventHandler(this.toolStripButtonDeletePatient_GEL_Click);

            this.toolStripButtonSearch_GEL.Name = "toolStripButtonSearch_GEL";
            this.toolStripButtonSearch_GEL.Size = new System.Drawing.Size(29, 24);

            this.toolStripButtonRefresh_GEL.Name = "toolStripButtonRefresh_GEL";
            this.toolStripButtonRefresh_GEL.Size = new System.Drawing.Size(82, 24);
            this.toolStripButtonRefresh_GEL.Text = "Обновить";
            this.toolStripButtonRefresh_GEL.Click += new System.EventHandler(this.toolStripButtonRefresh_GEL_Click);

            this.toolStripButtonSave_GEL.Name = "toolStripButtonSave_GEL";
            this.toolStripButtonSave_GEL.Size = new System.Drawing.Size(87, 24);
            this.toolStripButtonSave_GEL.Text = "Сохранить";
            this.toolStripButtonSave_GEL.Click += new System.EventHandler(this.toolStripButtonSave_GEL_Click);

            // panelSearch_GEL
            this.panelSearch_GEL.Controls.Add(this.buttonSearchExecute_GEL);
            this.panelSearch_GEL.Controls.Add(this.textBoxSearch_GEL);
            this.panelSearch_GEL.Controls.Add(this.labelSearch_GEL);
            this.panelSearch_GEL.Dock = DockStyle.Top;
            this.panelSearch_GEL.Location = new System.Drawing.Point(0, 0);
            this.panelSearch_GEL.Name = "panelSearch_GEL";
            this.panelSearch_GEL.Size = new System.Drawing.Size(1200, 50);
            this.panelSearch_GEL.TabIndex = 2;

            this.buttonSearchExecute_GEL.Location = new System.Drawing.Point(1105, 14);
            this.buttonSearchExecute_GEL.Name = "buttonSearchExecute_GEL";
            this.buttonSearchExecute_GEL.Size = new System.Drawing.Size(75, 28);
            this.buttonSearchExecute_GEL.TabIndex = 0;
            this.buttonSearchExecute_GEL.Text = "Найти";
            this.buttonSearchExecute_GEL.Click += new System.EventHandler(this.buttonSearchExecute_GEL_Click);

            this.textBoxSearch_GEL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.textBoxSearch_GEL.Location = new System.Drawing.Point(305, 15);
            this.textBoxSearch_GEL.Name = "textBoxSearch_GEL";
            this.textBoxSearch_GEL.Size = new System.Drawing.Size(787, 27);
            this.textBoxSearch_GEL.TabIndex = 1;

            this.labelSearch_GEL.AutoSize = true;
            this.labelSearch_GEL.Location = new System.Drawing.Point(10, 15);
            this.labelSearch_GEL.Name = "labelSearch_GEL";
            this.labelSearch_GEL.Size = new System.Drawing.Size(289, 20);
            this.labelSearch_GEL.TabIndex = 2;
            this.labelSearch_GEL.Text = "Поиск по фамилии, диагнозу или врачу:";

            // dataGridViewPatients_GEL
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            this.dataGridViewPatients_GEL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatients_GEL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewPatients_GEL.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dataGridViewPatients_GEL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatients_GEL.ColumnHeadersHeight = 40;
            this.dataGridViewPatients_GEL.GridColor = Color.Gray;
            this.dataGridViewPatients_GEL.Location = new Point(10, 120);
            this.dataGridViewPatients_GEL.Name = "dataGridViewPatients_GEL";
            this.dataGridViewPatients_GEL.ReadOnly = true;
            this.dataGridViewPatients_GEL.RowHeadersVisible = false;
            this.dataGridViewPatients_GEL.RowHeadersWidth = 51;
            this.dataGridViewPatients_GEL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients_GEL.Size = new Size(1170, 450);
            this.dataGridViewPatients_GEL.TabIndex = 3;
            this.dataGridViewPatients_GEL.DoubleClick += new EventHandler(this.dataGridViewPatients_GEL_DoubleClick);

            // КОЛОНКИ С РУССКИМИ ЗАГОЛОВКАМИ
            this.dataGridViewPatients_GEL.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { Name = "columnId_GEL", HeaderText = "ID", DataPropertyName = "Id", Width = 60 },
                new DataGridViewTextBoxColumn { Name = "columnFam_GEL", HeaderText = "Фамилия", DataPropertyName = "Fam", Width = 150 },
                new DataGridViewTextBoxColumn { Name = "columnIm_GEL", HeaderText = "Имя", DataPropertyName = "Im", Width = 120 },
                new DataGridViewTextBoxColumn { Name = "columnOtch_GEL", HeaderText = "Отчество", DataPropertyName = "Otch", Width = 150 },
                new DataGridViewTextBoxColumn { Name = "columnDateBirth_GEL", HeaderText = "Дата рождения", DataPropertyName = "DateBirth", Width = 130 },
                new DataGridViewTextBoxColumn { Name = "columnDoctor_GEL", HeaderText = "Врач", DataPropertyName = "Doctor", Width = 180 },
                new DataGridViewTextBoxColumn { Name = "columnSpec_GEL", HeaderText = "Специализация", DataPropertyName = "Spec", Width = 150 },
                new DataGridViewTextBoxColumn { Name = "columnDiag_GEL", HeaderText = "Диагноз", DataPropertyName = "Diag", Width = 180 },
                new DataGridViewTextBoxColumn { Name = "columnAmbul_GEL", HeaderText = "Амбулаторно", DataPropertyName = "Ambul", Width = 110 },
                new DataGridViewTextBoxColumn { Name = "columnDays_GEL", HeaderText = "Дни нетрудоспособности", DataPropertyName = "Days", Width = 140 },
                new DataGridViewTextBoxColumn { Name = "columnDisp_GEL", HeaderText = "Диспансерный учёт", DataPropertyName = "Disp", Width = 130 },
                new DataGridViewTextBoxColumn { Name = "columnPrim_GEL", HeaderText = "Примечание", DataPropertyName = "Prim", Width = 250 }
            });

            // groupBoxStats_GEL
            this.groupBoxStats_GEL.Controls.Add(this.labelCount_GEL);
            this.groupBoxStats_GEL.Controls.Add(this.labelCountValue_GEL);
            this.groupBoxStats_GEL.Controls.Add(this.labelSumDays_GEL);
            this.groupBoxStats_GEL.Controls.Add(this.labelSumDaysValue_GEL);
            this.groupBoxStats_GEL.Controls.Add(this.labelAvgDays_GEL);
            this.groupBoxStats_GEL.Controls.Add(this.labelAvgDaysValue_GEL);
            this.groupBoxStats_GEL.Controls.Add(this.labelAmbulYes_GEL);
            this.groupBoxStats_GEL.Controls.Add(this.labelAmbulYesValue_GEL);
            this.groupBoxStats_GEL.Dock = DockStyle.Bottom;
            this.groupBoxStats_GEL.Location = new Point(0, 650);
            this.groupBoxStats_GEL.Name = "groupBoxStats_GEL";
            this.groupBoxStats_GEL.Size = new Size(1200, 100);
            this.groupBoxStats_GEL.TabIndex = 4;
            this.groupBoxStats_GEL.TabStop = false;
            this.groupBoxStats_GEL.Text = "Статистика";

            this.labelCount_GEL.Location = new Point(15, 25);
            this.labelCount_GEL.Name = "labelCount_GEL";
            this.labelCount_GEL.Size = new Size(180, 23);
            this.labelCount_GEL.TabIndex = 0;
            this.labelCount_GEL.Text = "Количество пациентов:";

            this.labelCountValue_GEL.AutoSize = true;
            this.labelCountValue_GEL.Location = new Point(200, 25);
            this.labelCountValue_GEL.Name = "labelCountValue_GEL";
            this.labelCountValue_GEL.Size = new Size(0, 20);
            this.labelCountValue_GEL.TabIndex = 1;
            this.labelCountValue_GEL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.labelSumDays_GEL.Location = new Point(15, 55);
            this.labelSumDays_GEL.Name = "labelSumDays_GEL";
            this.labelSumDays_GEL.Size = new Size(220, 23);
            this.labelSumDays_GEL.TabIndex = 2;
            this.labelSumDays_GEL.Text = "Сумма дней нетрудоспособности:";

            this.labelSumDaysValue_GEL.AutoSize = true;
            this.labelSumDaysValue_GEL.Location = new Point(250, 55);
            this.labelSumDaysValue_GEL.Name = "labelSumDaysValue_GEL";
            this.labelSumDaysValue_GEL.Size = new Size(0, 20);
            this.labelSumDaysValue_GEL.TabIndex = 3;
            this.labelSumDaysValue_GEL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.labelAvgDays_GEL.Location = new Point(500, 25);
            this.labelAvgDays_GEL.Name = "labelAvgDays_GEL";
            this.labelAvgDays_GEL.Size = new Size(120, 23);
            this.labelAvgDays_GEL.TabIndex = 4;
            this.labelAvgDays_GEL.Text = "Среднее дней:";

            this.labelAvgDaysValue_GEL.AutoSize = true;
            this.labelAvgDaysValue_GEL.Location = new Point(620, 25);
            this.labelAvgDaysValue_GEL.Name = "labelAvgDaysValue_GEL";
            this.labelAvgDaysValue_GEL.Size = new Size(0, 20);
            this.labelAvgDaysValue_GEL.TabIndex = 5;
            this.labelAvgDaysValue_GEL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.labelAmbulYes_GEL.Location = new Point(500, 55);
            this.labelAmbulYes_GEL.Name = "labelAmbulYes_GEL";
            this.labelAmbulYes_GEL.Size = new Size(160, 23);
            this.labelAmbulYes_GEL.TabIndex = 6;
            this.labelAmbulYes_GEL.Text = "Амбулаторно (Да):";

            this.labelAmbulYesValue_GEL.AutoSize = true;
            this.labelAmbulYesValue_GEL.Location = new Point(670, 55);
            this.labelAmbulYesValue_GEL.Name = "labelAmbulYesValue_GEL";
            this.labelAmbulYesValue_GEL.Size = new Size(0, 20);
            this.labelAmbulYesValue_GEL.TabIndex = 7;
            this.labelAmbulYesValue_GEL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // FormMain
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.mainMenuStripPolyclinic_GEL);
            this.Controls.Add(this.toolStripMain_GEL);
            this.Controls.Add(this.panelSearch_GEL);
            this.Controls.Add(this.dataGridViewPatients_GEL);
            this.Controls.Add(this.groupBoxStats_GEL);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Управление пациентами поликлиники - Габеркорн Е.Л.";
            this.Load += new System.EventHandler(this.FormMain_Load);

            this.mainMenuStripPolyclinic_GEL.ResumeLayout(false);
            this.mainMenuStripPolyclinic_GEL.PerformLayout();
            this.toolStripMain_GEL.ResumeLayout(false);
            this.toolStripMain_GEL.PerformLayout();
            this.panelSearch_GEL.ResumeLayout(false);
            this.panelSearch_GEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_GEL)).EndInit();
            this.groupBoxStats_GEL.ResumeLayout(false);
            this.groupBoxStats_GEL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MenuStrip mainMenuStripPolyclinic_GEL;
        private ToolStripMenuItem toolStripMenuItemFile_GEL;
        private ToolStripMenuItem toolStripMenuItemSave_GEL;
        private ToolStripMenuItem toolStripMenuItemExit_GEL;
        private ToolStripMenuItem toolStripMenuItemPatient_GEL;
        private ToolStripMenuItem toolStripMenuItemAddPatient_GEL;
        private ToolStripMenuItem toolStripMenuItemEditPatient_GEL;
        private ToolStripMenuItem toolStripMenuItemDeletePatient_GEL;
        private ToolStripMenuItem toolStripMenuItemHelp_GEL;
        private ToolStripMenuItem toolStripMenuItemAbout_GEL;
        private ToolStripMenuItem toolStripMenuItemGuide_GEL;

        private ToolStrip toolStripMain_GEL;
        private ToolStripButton toolStripButtonAddPatient_GEL;
        private ToolStripButton toolStripButtonEditPatient_GEL;
        private ToolStripButton toolStripButtonDeletePatient_GEL;
        private ToolStripButton toolStripButtonSearch_GEL;
        private ToolStripButton toolStripButtonRefresh_GEL;
        private ToolStripButton toolStripButtonSave_GEL;

        private Panel panelSearch_GEL;
        private Label labelSearch_GEL;
        private TextBox textBoxSearch_GEL;
        private Button buttonSearchExecute_GEL;

        private DataGridView dataGridViewPatients_GEL;

        private GroupBox groupBoxStats_GEL;
        private Label labelCount_GEL;
        private Label labelCountValue_GEL;
        private Label labelSumDays_GEL;
        private Label labelSumDaysValue_GEL;
        private Label labelAvgDays_GEL;
        private Label labelAvgDaysValue_GEL;
        private Label labelAmbulYes_GEL;
        private Label labelAmbulYesValue_GEL;
    }
}