namespace Cursovaya3Kurs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Login = new Button();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 184);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 246);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // Login
            // 
            Login.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            Login.Location = new Point(103, 321);
            Login.Name = "Login";
            Login.Size = new Size(107, 32);
            Login.TabIndex = 4;
            Login.Text = "Войти";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.free_icon_eye_158746;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(243, 270);
            button1.Name = "button1";
            button1.Size = new Size(24, 23);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(84, 369);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 6;
            label3.Text = "Зарегистрироваться";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.curriculum;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(108, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 53);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 437);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выполните вход";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button Login;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
