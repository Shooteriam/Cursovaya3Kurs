namespace Cursovaya3Kurs
{
    partial class StartTest
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartTest));
            label1 = new Label();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button1.Location = new Point(853, 298);
            button1.Name = "button1";
            button1.Size = new Size(175, 32);
            button1.TabIndex = 1;
            button1.Text = "Следующий вопрос";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(12, 173);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(132, 30);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(12, 203);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 30);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(12, 233);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(132, 30);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(12, 263);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(132, 30);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(1000, 37);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 6;
            label2.Text = "id: -";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(911, 72);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // StartTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 336);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StartTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartTest";
            FormClosed += StartTest_FormClosed;
            Load += StartTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label label4;
    }
}