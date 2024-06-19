namespace Cursovaya3Kurs
{
    partial class SelectTopic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(275, 79);
            button1.Name = "button1";
            button1.Size = new Size(251, 34);
            button1.TabIndex = 2;
            button1.Text = "Определение структуры";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(275, 119);
            button2.Name = "button2";
            button2.Size = new Size(251, 34);
            button2.TabIndex = 3;
            button2.Text = "Создание объекта структуры";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(275, 162);
            button3.Name = "button3";
            button3.Size = new Size(251, 34);
            button3.TabIndex = 4;
            button3.Text = "Инициализация полей по умолчанию";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(275, 202);
            button4.Name = "button4";
            button4.Size = new Size(251, 34);
            button4.TabIndex = 5;
            button4.Text = "Конструкторы структуры";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(275, 242);
            button5.Name = "button5";
            button5.Size = new Size(251, 34);
            button5.TabIndex = 6;
            button5.Text = "Инициализатор структуры";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(275, 282);
            button6.Name = "button6";
            button6.Size = new Size(251, 34);
            button6.TabIndex = 7;
            button6.Text = "Копирование структуры с помощью with";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(320, 343);
            button7.Name = "button7";
            button7.Size = new Size(160, 28);
            button7.TabIndex = 8;
            button7.Text = "Срез по всем темам";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 9;
            label1.Text = "id: -";
            // 
            // SelectTopic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SelectTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectTopic";
            FormClosed += SelectTopic_FormClosed;
            Load += SelectTopic_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
    }
}