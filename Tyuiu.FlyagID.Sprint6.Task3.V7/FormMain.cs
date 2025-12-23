using System;
using System.Windows.Forms;
using Tyuiu.FlyagID.Sprint6.Task3.V7.Lib;

namespace Tyuiu.FlyagID.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
            ShowMatrix(ds.Calculate(null));
        }

        private void ShowMatrix(int[,] matrix)
        {
            dataGridViewResult.ColumnCount = matrix.GetLength(1);
            dataGridViewResult.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            ShowMatrix(ds.Calculate(null));
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6 | Таск 3 | Вариант 7\n" +
                "Сортировка по возрастанию 4-го столбца\n\n" +
                "Выполнил: Иван Фляг Дмитриевич\n" +
                "Группа: ИСПб-25-1",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
