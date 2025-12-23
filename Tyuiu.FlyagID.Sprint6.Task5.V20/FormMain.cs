using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.FlyagID.Sprint6.Task5.V20.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task5.V20
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private double[] values = Array.Empty<double>();

        private string filePath =
            @"C:\flyagIvan\Tyuiu.FlyagID.Sprint6\Sprint6Task5\InPutFileTask5V20.txt";

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            values = ds.LoadFromDataFile(filePath);

            dataGridViewResult.Rows.Clear();
            dataGridViewResult.Columns.Clear();
            dataGridViewResult.Columns.Add("col", "Кратные 2");

            foreach (double v in values)
                dataGridViewResult.Rows.Add(v.ToString("0.###"));

            pictureBoxChart.Refresh();
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (values.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int margin = 40;
            int w = pictureBoxChart.Width - margin * 2;
            int h = pictureBoxChart.Height - margin * 2;

            g.DrawLine(Pens.Black, margin, margin, margin, margin + h);
            g.DrawLine(Pens.Black, margin, margin + h, margin + w, margin + h);

            double max = values.Max();
            if (max == 0) max = 1;

            int barWidth = w / values.Length - 5;

            for (int i = 0; i < values.Length; i++)
            {
                int barHeight = (int)(values[i] / max * (h - 20));
                int x = margin + i * (barWidth + 5);
                int y = margin + h - barHeight;

                g.FillRectangle(Brushes.SteelBlue, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);

                g.DrawString(values[i].ToString("0.###"),
                    Font, Brushes.Black, x, y - 18);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6 | Таск 5 | Вариант 20\n" +
                "Студент: Иван Фляг Дмитриевич\n" +
                "Группа: ИСПб-25-1",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
