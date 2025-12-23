using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FlyagID.Sprint6.Task7.V24
{
    partial class FormMain
    {
        private GroupBox groupBoxTask;
        private Label labelTask;
        private FlowLayoutPanel panel;
        private Button buttonLoad;
        private Button buttonProcess;
        private Button buttonSave;
        private Button buttonInfo;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Label labelFile;

        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            panel = new FlowLayoutPanel();
            buttonLoad = new Button();
            buttonProcess = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            labelFile = new Label();
            groupBoxTask.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1100, 80);
            groupBoxTask.TabIndex = 4;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.Dock = DockStyle.Fill;
            labelTask.Location = new Point(3, 23);
            labelTask.Name = "labelTask";
            labelTask.Padding = new Padding(10);
            labelTask.Size = new Size(1094, 54);
            labelTask.TabIndex = 0;
            labelTask.Text = "Загрузить матрицу из CSV. Во второй строке заменить чётные элементы на 1.";
            // 
            // panel
            // 
            panel.Controls.Add(buttonLoad);
            panel.Controls.Add(buttonProcess);
            panel.Controls.Add(buttonSave);
            panel.Controls.Add(buttonInfo);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 80);
            panel.Name = "panel";
            panel.Size = new Size(1100, 50);
            panel.TabIndex = 3;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(3, 3);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(103, 32);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить";
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonProcess
            // 
            buttonProcess.Enabled = false;
            buttonProcess.Location = new Point(112, 3);
            buttonProcess.Name = "buttonProcess";
            buttonProcess.Size = new Size(99, 32);
            buttonProcess.TabIndex = 1;
            buttonProcess.Text = "Выполнить";
            buttonProcess.Click += buttonProcess_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(217, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(101, 32);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(324, 3);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(95, 32);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.Click += buttonInfo_Click;
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeight = 29;
            dataGridViewIn.Dock = DockStyle.Left;
            dataGridViewIn.Location = new Point(0, 153);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(500, 447);
            dataGridViewIn.TabIndex = 1;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeight = 29;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(500, 153);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(600, 447);
            dataGridViewOut.TabIndex = 0;
            // 
            // labelFile
            // 
            labelFile.Dock = DockStyle.Top;
            labelFile.Location = new Point(0, 130);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(1100, 23);
            labelFile.TabIndex = 2;
            labelFile.Text = "Файл не выбран";
            // 
            // FormMain
            // 
            ClientSize = new Size(1100, 600);
            Controls.Add(dataGridViewOut);
            Controls.Add(dataGridViewIn);
            Controls.Add(labelFile);
            Controls.Add(panel);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 24 | Иван Фляг Дмитриевич";
            groupBoxTask.ResumeLayout(false);
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }
    }
}
