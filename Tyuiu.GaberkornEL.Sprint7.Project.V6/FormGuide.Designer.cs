namespace Tyuiu.GaberkornEL.Sprint7.Project.V6
{
    // FormGuide_GEL.Designer.cs
    partial class FormGuide
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
            this.richTextBoxGuide_GEL = new RichTextBox();
            this.buttonCloseGuide_GEL = new Button();

            this.SuspendLayout();

            // Form
            this.Text = "Руководство - Габеркорн Е.Л.";
            this.Size = new System.Drawing.Size(700, 550);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            // richTextBoxGuide_GEL
            this.richTextBoxGuide_GEL.Dock = DockStyle.Fill;
            this.richTextBoxGuide_GEL.ReadOnly = true;
            this.richTextBoxGuide_GEL.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.richTextBoxGuide_GEL.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxGuide_GEL.Text =
                "КРАТКОЕ РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ\n\n" +
                "1. Добавление пациента\n" +
                "   - Нажмите кнопку «Добавить» на панели инструментов или выберите в меню Пациент -> Добавить\n" +
                "   - Заполните все поля в открывшемся окне\n" +
                "   - Нажмите «Сохранить»\n\n" +
                "2. Редактирование\n" +
                "   - Выделите пациента в таблице (клик или двойной клик)\n" +
                "   - Нажмите «Редактировать»\n" +
                "   - Внесите изменения и сохраните\n\n" +
                "3. Удаление\n" +
                "   - Выделите пациента\n" +
                "   - Нажмите кнопку «Удалить» и подтвердите действие\n\n" +
                "4. Поиск\n" +
                "   - Введите текст в поле поиска (фамилия, диагноз или врач)\n" +
                "   - Нажмите «Найти» или Enter\n\n" +
                "5. Статистика и график\n" +
                "   - Кнопки «Статистика» и «График» на панели инструментов\n" +
                "   - Данные обновляются автоматически\n\n" +
                "6. Сохранение\n" +
                "   - Изменения сохраняются автоматически после добавления/редактирования\n" +
                "   - Также можно нажать кнопку «Сохранить»\n\n" +
                "Все данные хранятся в файле patients.csv в папке с программой.";

            // buttonCloseGuide_GEL
            this.buttonCloseGuide_GEL.Dock = DockStyle.Bottom;
            this.buttonCloseGuide_GEL.Height = 40;
            this.buttonCloseGuide_GEL.Text = "Закрыть";
            this.buttonCloseGuide_GEL.DialogResult = DialogResult.OK;

            this.Controls.Add(this.richTextBoxGuide_GEL);
            this.Controls.Add(this.buttonCloseGuide_GEL);

            this.ResumeLayout(false);
        }

        private RichTextBox richTextBoxGuide_GEL;
        private Button buttonCloseGuide_GEL;
    }
}