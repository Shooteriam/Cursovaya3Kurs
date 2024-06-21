namespace Cursovaya3Kurs
{
    partial class UserStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStatistic));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(46, 26);
            label1.TabIndex = 0;
            label1.Text = "id: -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(57, 26);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(57, 26);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(57, 26);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.free_icon_back_3114883;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(12, 286);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 10F, FontStyle.Bold);
            button1.Location = new Point(136, 286);
            button1.Name = "button1";
            button1.Size = new Size(208, 30);
            button1.TabIndex = 5;
            button1.Text = "Сбросить статистику";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 237);
            label5.Name = "label5";
            label5.Size = new Size(57, 26);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // UserStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(481, 328);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserStatistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика пользователя";
            FormClosed += UserStatistic_FormClosed;
            Load += UserStatistic_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button1;
        private Label label5;
    }
}