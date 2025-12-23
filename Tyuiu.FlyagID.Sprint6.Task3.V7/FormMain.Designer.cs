using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FlyagID.Sprint6.Task3.V7
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult;
        private DataGridView dataGridViewResult;
        private Button buttonExecute;
        private Button buttonInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            dataGridViewResult = new DataGridView();
            buttonExecute = new Button();
            buttonInfo = new Button();

            SuspendLayout();

            // Условие
            groupBoxTask.Text = "Условие задачи";
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Size = new Size(520, 100);

            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Multiline = true;
            textBoxTask.ReadOnly = true;
            textBoxTask.Text =
                "Дан массив 5×5.\r\n" +
                "Отсортировать строки по возрастанию элементов\r\n" +
                "четвёртого столбца.";

            groupBoxTask.Controls.Add(textBoxTask);

            // Результат
            groupBoxResult.Text = "Результат";
            groupBoxResult.Location = new Point(12, 120);
            groupBoxResult.Size = new Size(520, 260);

            dataGridViewResult.Dock = DockStyle.Fill;
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.RowHeadersVisible = false;

            groupBoxResult.Controls.Add(dataGridViewResult);

            // Кнопки
            buttonExecute.Text = "Выполнить";
            buttonExecute.BackColor = Color.LightGreen;
            buttonExecute.Location = new Point(12, 395);
            buttonExecute.Size = new Size(160, 35);
            buttonExecute.Click += buttonExecute_Click;

            buttonInfo.Text = "Справка";
            buttonInfo.BackColor = Color.LightSkyBlue;
            buttonInfo.Location = new Point(372, 395);
            buttonInfo.Size = new Size(160, 35);
            buttonInfo.Click += buttonInfo_Click;

            // Форма
            ClientSize = new Size(550, 450);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 7 | Иван Фляг Д.";

            ResumeLayout(false);
        }
    }
}
