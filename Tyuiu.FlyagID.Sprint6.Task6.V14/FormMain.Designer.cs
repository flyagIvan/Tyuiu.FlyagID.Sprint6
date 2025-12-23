using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FlyagID.Sprint6.Task6.V14
{
    partial class FormMain
    {
        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private FlowLayoutPanel panelButtons;
        private Button buttonLoad;
        private Button buttonProcess;
        private Button buttonSave;
        private Button buttonInfo;
        private Label labelFileInfo;

        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxIn = new GroupBox();
            groupBoxOut = new GroupBox();
            textBoxIn = new TextBox();
            textBoxOut = new TextBox();
            panelButtons = new FlowLayoutPanel();
            buttonLoad = new Button();
            buttonProcess = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();
            labelFileInfo = new Label();

            SuspendLayout();

            // groupBoxTask
            groupBoxTask.Text = "Условие";
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Height = 80;

            labelTask.Text =
                "Загрузить текстовый файл.\n" +
                "Вывести слова, содержащие букву 'z'.";
            labelTask.Dock = DockStyle.Fill;
            labelTask.Padding = new Padding(10);

            groupBoxTask.Controls.Add(labelTask);

            // panelButtons
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Height = 60;
            panelButtons.Padding = new Padding(10);

            string imgPath = @"C:\flyagIvan\Tyuiu.FlyagID.Sprint6\img\";
            Size btnSize = new Size(45, 45);

            buttonLoad.Size = btnSize;
            buttonLoad.BackgroundImage = Image.FromFile(imgPath + "folder_add.png");
            buttonLoad.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLoad.Click += buttonLoad_Click;

            buttonProcess.Size = btnSize;
            buttonProcess.BackgroundImage = Image.FromFile(imgPath + "page_white_go.png");
            buttonProcess.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProcess.Enabled = false;
            buttonProcess.Click += buttonProcess_Click;

            buttonSave.Size = btnSize;
            buttonSave.BackgroundImage = Image.FromFile(imgPath + "save.png");
            buttonSave.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave.Enabled = false;
            buttonSave.Click += buttonSave_Click;

            buttonInfo.Size = btnSize;
            buttonInfo.BackgroundImage = Image.FromFile(imgPath + "help.png");
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo.Click += buttonInfo_Click;

            panelButtons.Controls.AddRange(new Control[]
            {
                buttonLoad, buttonProcess, buttonSave, buttonInfo
            });

            // groupBoxIn
            groupBoxIn.Text = "Исходный текст";
            groupBoxIn.Dock = DockStyle.Left;
            groupBoxIn.Width = 480;

            textBoxIn.Multiline = true;
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.ScrollBars = ScrollBars.Vertical;

            groupBoxIn.Controls.Add(textBoxIn);

            // groupBoxOut
            groupBoxOut.Text = "Результат";
            groupBoxOut.Dock = DockStyle.Fill;

            textBoxOut.Multiline = true;
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.ScrollBars = ScrollBars.Vertical;

            groupBoxOut.Controls.Add(textBoxOut);

            // labelFileInfo
            labelFileInfo.AutoSize = true;
            labelFileInfo.Location = new Point(10, 150);

            // Form
            ClientSize = new Size(1000, 600);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxIn);
            Controls.Add(labelFileInfo);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxTask);

            Text = "Спринт 6 | Task 6 | Variant 14 | Иван Фляг";
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
