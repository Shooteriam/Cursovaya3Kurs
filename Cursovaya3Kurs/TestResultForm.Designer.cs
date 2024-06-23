namespace Cursovaya3Kurs
{
    partial class TestResultForm
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 129);
            label1.Name = "label1";
            label1.Size = new Size(57, 26);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button1.Location = new Point(274, 278);
            button1.Name = "button1";
            button1.Size = new Size(180, 32);
            button1.TabIndex = 2;
            button1.Text = "В меню";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button2.Location = new Point(88, 278);
            button2.Name = "button2";
            button2.Size = new Size(180, 32);
            button2.TabIndex = 3;
            button2.Text = "Смотреть ошибки";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TestResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 322);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "TestResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результаты";
            FormClosed += TestResultForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}