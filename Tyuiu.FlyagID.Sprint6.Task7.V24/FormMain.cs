using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tyuiu.FlyagID.Sprint6.Task7.V24.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        private string filePath = string.Empty;
        private int[,] resultMatrix;
        private readonly DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                dataGridViewIn.DataSource = LoadTable(filePath);
                labelFile.Text = "Файл: " + Path.GetFileName(filePath);
                buttonProcess.Enabled = true;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            resultMatrix = ds.GetMatrix(filePath);
            dataGridViewOut.DataSource = ConvertToTable(resultMatrix);
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = "OutPutFileTask7.csv",
                Filter = "CSV файлы (*.csv)|*.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(sfd.FileName);
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        sw.Write(resultMatrix[i, j]);
                        if (j < resultMatrix.GetLength(1) - 1)
                            sw.Write(";");
                    }
                    sw.WriteLine();
                }

                MessageBox.Show("Файл сохранён");
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Form info = new Form
            {
                Size = new Size(500, 280),
                StartPosition = FormStartPosition.CenterScreen,
                Text = "О программе"
            };

            PictureBox pic = new PictureBox
            {
                Image = Image.FromFile(
                    @"C:\flyagIvan\Tyuiu.FlyagID.Sprint6\img\ava.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(130, 180),
                Location = new Point(20, 20)
            };

            Label lbl = new Label
            {
                Text =
                    "Иван Фляг Дмитриевич\n" +
                    "ИСПб-25-1\n" +
                    "Спринт 6 | Таск 7 | Вариант 24\n" +
                    "ТИУ 2025",
                Location = new Point(180, 40),
                AutoSize = true
            };

            info.Controls.Add(pic);
            info.Controls.Add(lbl);
            info.ShowDialog();
        }

        private DataTable LoadTable(string path)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(path);
            string[] headers = lines[0].Split(';');

            foreach (string h in headers)
                dt.Columns.Add(h);

            foreach (string line in lines)
                dt.Rows.Add(line.Split(';'));

            return dt;
        }

        private DataTable ConvertToTable(int[,] m)
        {
            DataTable dt = new DataTable();
            for (int j = 0; j < m.GetLength(1); j++)
                dt.Columns.Add("C" + (j + 1));

            for (int i = 0; i < m.GetLength(0); i++)
            {
                DataRow r = dt.NewRow();
                for (int j = 0; j < m.GetLength(1); j++)
                    r[j] = m[i, j];
                dt.Rows.Add(r);
            }

            return dt;
        }
    }
}
