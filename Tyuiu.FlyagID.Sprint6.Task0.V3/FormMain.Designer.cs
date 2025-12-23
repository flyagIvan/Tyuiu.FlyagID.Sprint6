using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.FlyagID.Sprint6.Task0.V3
{
    partial class FormMain
    {
        private GroupBox groupBoxTask;
        private PictureBox pictureBoxFormula;
        private Label labelTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Label labelX;
        private TextBox textBoxX;
        private Button buttonExecute;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            pictureBoxFormula = new PictureBox();
            labelTask = new Label();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            labelX = new Label();
            textBoxX = new TextBox();
            buttonExecute = new Button();
            buttonInfo = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(500, 140);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.ImageLocation = "C:\\flyagIvan\\img\\task0_v3.png";
            pictureBoxFormula.Location = new Point(10, 22);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(480, 60);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            // 
            // labelTask
            // 
            labelTask.Location = new Point(10, 90);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(480, 40);
            labelTask.TabIndex = 1;
            labelTask.Text = "Вычислить значение функции y = (4x³) / (x³ − 1)";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(12, 160);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(500, 90);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(10, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(480, 50);
            textBoxResult.TabIndex = 0;
            // 
            // labelX
            // 
            labelX.Location = new Point(12, 260);
            labelX.Name = "labelX";
            labelX.Size = new Size(100, 23);
            labelX.TabIndex = 2;
            labelX.Text = "Введите x:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(110, 257);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(90, 27);
            textBoxX.TabIndex = 3;
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(220, 255);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(120, 38);
            buttonExecute.TabIndex = 4;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(350, 255);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(80, 38);
            buttonInfo.TabIndex = 5;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 310);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxResult);
            Controls.Add(labelX);
            Controls.Add(textBoxX);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 0 | Variant 3 | Иван Фляг";
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
