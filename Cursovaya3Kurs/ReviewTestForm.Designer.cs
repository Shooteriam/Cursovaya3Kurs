namespace Cursovaya3Kurs
{
    partial class ReviewTestForm
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
            label4 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button1.Location = new Point(542, 404);
            button1.Name = "button1";
            button1.Size = new Size(135, 32);
            button1.TabIndex = 2;
            button1.Text = "Дальше";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button2.Location = new Point(12, 404);
            button2.Name = "button2";
            button2.Size = new Size(135, 32);
            button2.TabIndex = 3;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 80);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(12, 286);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(132, 30);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(12, 256);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(132, 30);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(12, 226);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 30);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(12, 196);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(132, 30);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 95);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button3.Location = new Point(277, 404);
            button3.Name = "button3";
            button3.Size = new Size(135, 32);
            button3.TabIndex = 15;
            button3.Text = "В меню";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ReviewTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 448);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ReviewTestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ваши ошибки";
            FormClosed += ReviewTestForm_FormClosed;
            Load += ReviewTestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label4;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button button3;
    }
}