using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FlyagID.Sprint6.Task5.V20
{
    partial class FormMain
    {
        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxTable;
        private DataGridView dataGridViewResult;
        private GroupBox groupBoxChart;
        private PictureBox pictureBoxChart;
        private Button buttonExecute;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxTable = new GroupBox();
            dataGridViewResult = new DataGridView();
            groupBoxChart = new GroupBox();
            pictureBoxChart = new PictureBox();
            buttonExecute = new Button();
            buttonInfo = new Button();

            // Условие
            groupBoxTask.Text = "Условие";
            groupBoxTask.Location = new Point(10, 10);
            groupBoxTask.Size = new Size(780, 80);

            labelTask.Dock = DockStyle.Fill;
            labelTask.Text =
                "Прочитать данные из файла InPutFileTask5V20.txt\n" +
                "Вывести числа, кратные 2, и построить диаграмму.";
            labelTask.TextAlign = ContentAlignment.MiddleLeft;

            groupBoxTask.Controls.Add(labelTask);

            // Таблица
            groupBoxTable.Text = "Таблица значений";
            groupBoxTable.Location = new Point(10, 100);
            groupBoxTable.Size = new Size(380, 350);

            dataGridViewResult.Dock = DockStyle.Fill;
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.RowHeadersVisible = false;

            groupBoxTable.Controls.Add(dataGridViewResult);

            // Диаграмма
            groupBoxChart.Text = "Диаграмма";
            groupBoxChart.Location = new Point(400, 100);
            groupBoxChart.Size = new Size(390, 350);

            pictureBoxChart.Dock = DockStyle.Fill;
            pictureBoxChart.BackColor = Color.White;
            pictureBoxChart.Paint += pictureBoxChart_Paint;

            groupBoxChart.Controls.Add(pictureBoxChart);

            // Кнопки
            buttonExecute.Text = "Выполнить";
            buttonExecute.BackColor = Color.LightGreen;
            buttonExecute.Location = new Point(10, 470);
            buttonExecute.Size = new Size(150, 40);
            buttonExecute.Click += buttonExecute_Click;

            buttonInfo.Text = "Справка";
            buttonInfo.BackColor = Color.LightSkyBlue;
            buttonInfo.Location = new Point(640, 470);
            buttonInfo.Size = new Size(150, 40);
            buttonInfo.Click += buttonInfo_Click;

            // Форма
            ClientSize = new Size(800, 530);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxTable);
            Controls.Add(groupBoxChart);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 20 | Иван Фляг Д.";

            ResumeLayout(false);
        }
    }
}
