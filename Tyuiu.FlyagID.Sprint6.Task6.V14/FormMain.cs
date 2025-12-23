using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tyuiu.FlyagID.Sprint6.Task6.V14.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.FlyagID.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        private string? selectedFile;
        private readonly DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                InitialDirectory = @"C:\flyagIvan\Tyuiu.FlyagID.Sprint6\Sprint6Task6"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFile = ofd.FileName;
                textBoxIn.Text = File.ReadAllText(selectedFile);
                labelFileInfo.Text = "Файл: " + Path.GetFileName(selectedFile);

                buttonProcess.Enabled = true;
                buttonSave.Enabled = false;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            string temp = Path.GetTempFileName();
            File.WriteAllText(temp, textBoxIn.Text);

            textBoxOut.Text = ds.CollectTextFromFile(temp);
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                FileName = "OutPutFileTask6V14.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBoxOut.Text);
                MessageBox.Show("Файл сохранён!", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Form info = new Form
            {
                Text = "О программе",
                Size = new Size(520, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            PictureBox pic = new PictureBox
            {
                Image = Image.FromFile(
                    @"C:\flyagIvan\Tyuiu.FlyagID.Sprint6\img\ava.jpg"),
                Size = new Size(120, 160),
                Location = new Point(20, 20),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Label lbl = new Label
            {
                Text =
                "Иван Фляг Дмитриевич\n" +
                "ИСПб-25-1\n" +
                "Спринт 6 | Задание 6 | Вариант 14\n" +
                "ТИУ 2025",
                Location = new Point(160, 30),
                AutoSize = true
            };

            info.Controls.Add(pic);
            info.Controls.Add(lbl);
            info.ShowDialog();
        }
    }
}
