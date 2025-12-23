using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FlyagID.Sprint6.Task2.V20
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxFormula_AF;
        private PictureBox pictureBoxFormula_AF;

        private GroupBox groupBoxTable_AF;
        private DataGridView dataGridViewResult_AF;

        private GroupBox groupBoxChart_AF;
        private PictureBox pictureBoxChart_AF;

        private Button buttonExecute_AF;
        private Button buttonInfo_AF;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxFormula_AF = new GroupBox();
            pictureBoxFormula_AF = new PictureBox();

            groupBoxTable_AF = new GroupBox();
            dataGridViewResult_AF = new DataGridView();

            groupBoxChart_AF = new GroupBox();
            pictureBoxChart_AF = new PictureBox();

            buttonExecute_AF = new Button();
            buttonInfo_AF = new Button();

            SuspendLayout();

            // === Условие ===
            groupBoxFormula_AF.Text = "Условие задачи";
            groupBoxFormula_AF.Location = new Point(10, 10);
            groupBoxFormula_AF.Size = new Size(480, 240);

            pictureBoxFormula_AF.Dock = DockStyle.Fill;
            pictureBoxFormula_AF.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_AF.Image = Image.FromFile(
                @"C:\flyagIvan\img\task2.png"
            );

            groupBoxFormula_AF.Controls.Add(pictureBoxFormula_AF);

            // === Таблица ===
            groupBoxTable_AF.Text = "Таблица значений";
            groupBoxTable_AF.Location = new Point(10, 260);
            groupBoxTable_AF.Size = new Size(480, 320);

            dataGridViewResult_AF.Dock = DockStyle.Fill;
            dataGridViewResult_AF.ReadOnly = true;
            dataGridViewResult_AF.AllowUserToAddRows = false;
            dataGridViewResult_AF.RowHeadersVisible = false;
            dataGridViewResult_AF.ColumnCount = 2;
            dataGridViewResult_AF.Columns[0].Name = "X";
            dataGridViewResult_AF.Columns[1].Name = "f(x)";
            dataGridViewResult_AF.Columns[0].Width = 80;
            dataGridViewResult_AF.Columns[1].Width = 150;

            groupBoxTable_AF.Controls.Add(dataGridViewResult_AF);

            // === График ===
            groupBoxChart_AF.Text = "График функции";
            groupBoxChart_AF.Location = new Point(500, 10);
            groupBoxChart_AF.Size = new Size(780, 570);

            pictureBoxChart_AF.Dock = DockStyle.Fill;
            pictureBoxChart_AF.BackColor = Color.White;
            pictureBoxChart_AF.Paint += pictureBoxChart_AF_Paint;

            groupBoxChart_AF.Controls.Add(pictureBoxChart_AF);

            // === Кнопки ===
            buttonExecute_AF.Text = "Выполнить";
            buttonExecute_AF.BackColor = Color.LightGreen;
            buttonExecute_AF.Size = new Size(180, 35);
            buttonExecute_AF.Location = new Point(500, 590);
            buttonExecute_AF.Click += buttonExecute_AF_Click;

            buttonInfo_AF.Text = "Справка";
            buttonInfo_AF.BackColor = Color.LightSkyBlue;
            buttonInfo_AF.Size = new Size(180, 35);
            buttonInfo_AF.Location = new Point(700, 590);
            buttonInfo_AF.Click += buttonInfo_AF_Click;

            // === Форма ===
            ClientSize = new Size(1300, 650);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 2 | Variant 20 | Иван Фляг Дмитриевич";

            Controls.Add(groupBoxFormula_AF);
            Controls.Add(groupBoxTable_AF);
            Controls.Add(groupBoxChart_AF);
            Controls.Add(buttonExecute_AF);
            Controls.Add(buttonInfo_AF);

            ResumeLayout(false);
        }
    }
}
