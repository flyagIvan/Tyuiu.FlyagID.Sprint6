using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.FlyagID.Sprint6.Task2.V20.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task2.V20
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private double[] values = Array.Empty<double>();
        private int startX = -5;
        private int stopX = 5;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_AF_Click(object sender, EventArgs e)
        {
            values = ds.GetMassFunction(startX, stopX);

            dataGridViewResult_AF.Rows.Clear();
            for (int i = 0; i < values.Length; i++)
            {
                dataGridViewResult_AF.Rows.Add(startX + i, values[i]);
            }

            pictureBoxChart_AF.Refresh();
        }

        private void pictureBoxChart_AF_Paint(object sender, PaintEventArgs e)
        {
            if (values.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int w = pictureBoxChart_AF.Width - 40;
            int h = pictureBoxChart_AF.Height - 40;

            using (Pen axisPen = new Pen(Color.Black, 2))
            {
                g.DrawLine(axisPen, 20, h / 2 + 20, w + 20, h / 2 + 20);
                g.DrawLine(axisPen, 20, 20, 20, h + 20);
            }

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double v in values)
            {
                min = Math.Min(min, v);
                max = Math.Max(max, v);
            }

            if (Math.Abs(max - min) < 0.001)
            {
                max += 1;
                min -= 1;
            }

            double dx = w / (double)(values.Length - 1);
            double scaleY = h / (max - min);

            using (Pen graphPen = new Pen(Color.Blue, 2))
            {
                for (int i = 0; i < values.Length - 1; i++)
                {
                    float x1 = (float)(20 + i * dx);
                    float x2 = (float)(20 + (i + 1) * dx);

                    float y1 = (float)(20 + h - (values[i] - min) * scaleY);
                    float y2 = (float)(20 + h - (values[i + 1] - min) * scaleY);

                    g.DrawLine(graphPen, x1, y1, x2, y2);
                }
            }
        }

        private void buttonInfo_AF_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sprint 6\nTask 2\nВариант 20\n" +
                "Выполнил: Иван Фляг Дмитриевич\nГруппа ИСПб-25-1",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
