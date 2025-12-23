namespace Tyuiu.GaberkornEL.Sprint7.Project.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelTitle_GEL = new Label();
            labelAuthor_GEL = new Label();
            labelVariant_GEL = new Label();
            labelSprint_GEL = new Label();
            labelDescription_GEL = new Label();
            buttonCloseAbout_GEL = new Button();
            SuspendLayout();
            // 
            // labelTitle_GEL
            // 
            labelTitle_GEL.AutoSize = true;
            labelTitle_GEL.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle_GEL.Location = new Point(29, 9);
            labelTitle_GEL.Name = "labelTitle_GEL";
            labelTitle_GEL.Size = new Size(473, 32);
            labelTitle_GEL.TabIndex = 5;
            labelTitle_GEL.Text = "Управление пациентами поликлиники";
            // 
            // labelAuthor_GEL
            // 
            labelAuthor_GEL.AutoSize = true;
            labelAuthor_GEL.Location = new Point(98, 58);
            labelAuthor_GEL.Name = "labelAuthor_GEL";
            labelAuthor_GEL.Size = new Size(348, 23);
            labelAuthor_GEL.TabIndex = 4;
            labelAuthor_GEL.Text = "Разработчик: Габеркорн Егор Леонидович";
            // 
            // labelVariant_GEL
            // 
            labelVariant_GEL.AutoSize = true;
            labelVariant_GEL.Location = new Point(197, 97);
            labelVariant_GEL.Name = "labelVariant_GEL";
            labelVariant_GEL.Size = new Size(93, 23);
            labelVariant_GEL.TabIndex = 3;
            labelVariant_GEL.Text = "Вариант: 6";
            // 
            // labelSprint_GEL
            // 
            labelSprint_GEL.AutoSize = true;
            labelSprint_GEL.Location = new Point(197, 120);
            labelSprint_GEL.Name = "labelSprint_GEL";
            labelSprint_GEL.Size = new Size(86, 23);
            labelSprint_GEL.TabIndex = 2;
            labelSprint_GEL.Text = "Спринт: 7";
            labelSprint_GEL.Click += labelSprint_GEL_Click;
            // 
            // labelDescription_GEL
            // 
            labelDescription_GEL.Location = new Point(29, 158);
            labelDescription_GEL.Name = "labelDescription_GEL";
            labelDescription_GEL.Size = new Size(513, 290);
            labelDescription_GEL.TabIndex = 1;
            labelDescription_GEL.Text = resources.GetString("labelDescription_GEL.Text");
            labelDescription_GEL.Click += labelDescription_GEL_Click;
            // 
            // buttonCloseAbout_GEL
            // 
            buttonCloseAbout_GEL.DialogResult = DialogResult.OK;
            buttonCloseAbout_GEL.Location = new Point(197, 413);
            buttonCloseAbout_GEL.Name = "buttonCloseAbout_GEL";
            buttonCloseAbout_GEL.Size = new Size(120, 35);
            buttonCloseAbout_GEL.TabIndex = 0;
            buttonCloseAbout_GEL.Text = "Закрыть";
            // 
            // FormAbout
            // 
            AcceptButton = buttonCloseAbout_GEL;
            ClientSize = new Size(551, 464);
            Controls.Add(buttonCloseAbout_GEL);
            Controls.Add(labelDescription_GEL);
            Controls.Add(labelSprint_GEL);
            Controls.Add(labelVariant_GEL);
            Controls.Add(labelAuthor_GEL);
            Controls.Add(labelTitle_GEL);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе - Габеркорн Е.Л.";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTitle_GEL;
        private Label labelAuthor_GEL;
        private Label labelVariant_GEL;
        private Label labelSprint_GEL;
        private Label labelDescription_GEL;
        private Button buttonCloseAbout_GEL;
    }
}