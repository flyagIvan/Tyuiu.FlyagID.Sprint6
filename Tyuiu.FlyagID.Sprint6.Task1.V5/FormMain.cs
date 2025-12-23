using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.FlyagID.Sprint6.Task1.V5.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_AF_Click(object sender, EventArgs e)
        {
            int startValue = -5;
            int stopValue = 5;

            double[] values = ds.GetMassFunction(startValue, stopValue);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("******************************");
            sb.AppendLine("*   x   |     f(x)           *");
            sb.AppendLine("******************************");

            for (int i = 0; i < values.Length; i++)
            {
                int x = startValue + i;
                sb.AppendLine($"* {x,4} | {values[i],10:F2}       *");
            }

            sb.AppendLine("******************************");

            textBoxResult_AF.Text = sb.ToString();
        }

        private void buttonInfo_AF_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sprint 6 | Task 1 | Variant 5\nИван Фляг Дмитриевич\nГруппа ИСПб-25-1",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
