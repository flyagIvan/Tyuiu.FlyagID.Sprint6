using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.FlyagID.Sprint6.Task4.V4.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task4.V4
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private double[] values = Array.Empty<double>();
        private int startX = -5;
        private int endX = 5;

        public FormMain()
        {
            InitializeComponent();
            buttonSave.Enabled = false;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            values = ds.GetMassFunction(startX, endX);
            ShowTable();
            pictureBoxChart.Refresh();
            buttonSave.Enabled = true;
        }

        private void ShowTable()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("******************************");
            sb.AppendLine("*   x   *       f(x)        *");
            sb.AppendLine("******************************");

            for (int i = 0; i < values.Length; i++)
                sb.AppendLine($"* {startX + i,4} * {values[i],12:F2} *");

            sb.AppendLine("******************************");
            textBoxResult.Text = sb.ToString();
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (values.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int w = pictureBoxChart.Width - 40;
            int h = pictureBoxChart.Height - 40;

            g.DrawLine(Pens.Black, 20, h / 2 + 20, w + 20, h / 2 + 20);
            g.DrawLine(Pens.Black, 20, 20, 20, h + 20);

            double min = double.MaxValue;
            double max = double.MinValue;
            foreach (double v in values)
            {
                min = Math.Min(min, v);
                max = Math.Max(max, v);
            }

            if (Math.Abs(max - min) < 0.001)
            {
                max += 2;
                min -= 2;
            }

            double dx = w / (double)(values.Length - 1);
            double scaleY = h / (max - min);

            for (int i = 0; i < values.Length - 1; i++)
            {
                float x1 = (float)(20 + i * dx);
                float x2 = (float)(20 + (i + 1) * dx);
                float y1 = (float)(20 + h - (values[i] - min) * scaleY);
                float y2 = (float)(20 + h - (values[i + 1] - min) * scaleY);
                g.DrawLine(Pens.Blue, x1, y1, x2, y2);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "OutPutFileTask4V4.txt");

            ds.SaveToFile(values, path);

            MessageBox.Show(
                "Файл сохранён:\n" + path,
                "Готово",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6 | Таск 4 | Вариант 4\n" +
                "f(x) = ((2x + 6) / cos(x) + x) - 3\n\n" +
                "Выполнил: Иван Фляг Дмитриевич\n" +
                "Группа: ИСПб-25-1",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
