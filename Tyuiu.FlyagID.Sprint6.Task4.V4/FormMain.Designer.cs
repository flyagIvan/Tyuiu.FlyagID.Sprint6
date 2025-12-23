using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FlyagID.Sprint6.Task4.V4
{
    partial class FormMain
    {
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private GroupBox groupBoxChart;
        private PictureBox pictureBoxChart;
        private Button buttonCalc;
        private Button buttonSave;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxChart = new GroupBox();
            pictureBoxChart = new PictureBox();
            buttonCalc = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();

            // Условие
            groupBoxTask.Text = "Условие";
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Height = 100;

            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Multiline = true;
            textBoxTask.ReadOnly = true;
            textBoxTask.Text =
                "f(x) = ((2x + 6) / cos(x) + x) - 3\r\n" +
                "Диапазон [-5;5], шаг 1";

            groupBoxTask.Controls.Add(textBoxTask);

            // Таблица
            groupBoxResult.Text = "Таблица значений";
            groupBoxResult.Dock = DockStyle.Left;
            groupBoxResult.Width = 420;

            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Multiline = true;
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;

            groupBoxResult.Controls.Add(textBoxResult);

            // График
            groupBoxChart.Text = "График функции";
            groupBoxChart.Dock = DockStyle.Fill;

            pictureBoxChart.Dock = DockStyle.Fill;
            pictureBoxChart.BackColor = Color.White;
            pictureBoxChart.Paint += pictureBoxChart_Paint;

            groupBoxChart.Controls.Add(pictureBoxChart);

            // Кнопки
            buttonCalc.Text = "Выполнить";
            buttonCalc.BackColor = Color.LightGreen;
            buttonCalc.Dock = DockStyle.Bottom;
            buttonCalc.Height = 40;
            buttonCalc.Click += buttonCalc_Click;

            buttonSave.Text = "Сохранить";
            buttonSave.BackColor = Color.LightSalmon;
            buttonSave.Dock = DockStyle.Bottom;
            buttonSave.Height = 40;
            buttonSave.Click += buttonSave_Click;

            buttonInfo.Text = "Справка";
            buttonInfo.BackColor = Color.LightSkyBlue;
            buttonInfo.Dock = DockStyle.Bottom;
            buttonInfo.Height = 40;
            buttonInfo.Click += buttonInfo_Click;

            // Форма
            ClientSize = new Size(1000, 600);
            Controls.Add(groupBoxChart);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonInfo);
            Controls.Add(buttonSave);
            Controls.Add(buttonCalc);

            Text = "Спринт 6 | Таск 4 | Вариант 4 | Иван Фляг Д.";
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
