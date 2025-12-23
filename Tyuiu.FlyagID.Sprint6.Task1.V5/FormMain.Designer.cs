using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FlyagID.Sprint6.Task1.V5
{
    partial class FormMain
    {
        private GroupBox groupBoxTask_AF;
        private PictureBox pictureBoxTask_AF;
        private GroupBox groupBoxOutput_AF;
        private TextBox textBoxResult_AF;
        private Button buttonExecute_AF;
        private Button buttonInfo_AF;

        private void InitializeComponent()
        {
            groupBoxTask_AF = new GroupBox();
            pictureBoxTask_AF = new PictureBox();
            groupBoxOutput_AF = new GroupBox();
            textBoxResult_AF = new TextBox();
            buttonExecute_AF = new Button();
            buttonInfo_AF = new Button();

            SuspendLayout();

            // Form
            ClientSize = new Size(900, 520);
            Text = "Sprint 6 | Task 1 | Variant 5 | Иван Фляг";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            // groupBoxTask
            groupBoxTask_AF.Text = "Условие";
            groupBoxTask_AF.Location = new Point(10, 10);
            groupBoxTask_AF.Size = new Size(430, 500);

            pictureBoxTask_AF.Dock = DockStyle.Fill;
            pictureBoxTask_AF.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTask_AF.Image = Image.FromFile(@"C:\flyagIvan\img\task1_v5.png");

            groupBoxTask_AF.Controls.Add(pictureBoxTask_AF);

            // groupBoxOutput
            groupBoxOutput_AF.Text = "Результат";
            groupBoxOutput_AF.Location = new Point(450, 10);
            groupBoxOutput_AF.Size = new Size(430, 400);

            textBoxResult_AF.Multiline = true;
            textBoxResult_AF.ReadOnly = true;
            textBoxResult_AF.ScrollBars = ScrollBars.Vertical;
            textBoxResult_AF.Font = new Font("Consolas", 11F);
            textBoxResult_AF.Dock = DockStyle.Fill;

            groupBoxOutput_AF.Controls.Add(textBoxResult_AF);

            // buttonExecute
            buttonExecute_AF.Text = "Выполнить";
            buttonExecute_AF.Size = new Size(200, 45);
            buttonExecute_AF.Location = new Point(680, 430);
            buttonExecute_AF.BackColor = Color.LightGreen;
            buttonExecute_AF.Click += buttonExecute_AF_Click;

            // buttonInfo
            buttonInfo_AF.Text = "Справка";
            buttonInfo_AF.Size = new Size(150, 45);
            buttonInfo_AF.Location = new Point(450, 430);
            buttonInfo_AF.Click += buttonInfo_AF_Click;

            Controls.Add(groupBoxTask_AF);
            Controls.Add(groupBoxOutput_AF);
            Controls.Add(buttonExecute_AF);
            Controls.Add(buttonInfo_AF);

            ResumeLayout(false);
        }
    }
}
