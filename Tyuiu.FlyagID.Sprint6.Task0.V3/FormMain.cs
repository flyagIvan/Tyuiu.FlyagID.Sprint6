using System;
using System.Windows.Forms;
using Tyuiu.FlyagID.Sprint6.Task0.V3.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.FlyagID.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBoxX.Text);
                double result = ds.Calculate(x);
                textBoxResult.Text = result.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Введите корректное значение x",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sprint 6 | Task 0\nИван Фляг Дмитриевич\nГруппа ИСПб-25-1\nВариант 3",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
