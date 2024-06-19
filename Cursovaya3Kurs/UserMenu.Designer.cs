namespace Cursovaya3Kurs
{
    partial class UserMenu
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "id: -";
            // 
            // button1
            // 
            button1.Location = new Point(230, 117);
            button1.Name = "button1";
            button1.Size = new Size(152, 34);
            button1.TabIndex = 1;
            button1.Text = "Теория";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(230, 157);
            button2.Name = "button2";
            button2.Size = new Size(152, 34);
            button2.TabIndex = 2;
            button2.Text = "Пройти тесты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(230, 197);
            button3.Name = "button3";
            button3.Size = new Size(152, 34);
            button3.TabIndex = 3;
            button3.Text = "Статистика";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 348);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UserMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMenu";
            FormClosing += UserMenu_FormClosing;
            Load += UserMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}