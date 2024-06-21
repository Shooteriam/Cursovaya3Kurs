namespace Cursovaya3Kurs
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button1.Location = new Point(60, 345);
            button1.Name = "button1";
            button1.Size = new Size(193, 32);
            button1.TabIndex = 0;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 23);
            textBox3.TabIndex = 3;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 104);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 4;
            label1.Text = "Введите логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 155);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 5;
            label2.Text = "Введите пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 209);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 6;
            label3.Text = "Повторите пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(130, 389);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 7;
            label4.Text = "Войти";
            label4.Click += label4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(64, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 25);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Я администратор";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 302);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Введите пароль администратора";
            textBox4.Size = new Size(201, 23);
            textBox4.TabIndex = 9;
            textBox4.Visible = false;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.free_icon_eye_158746;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(256, 233);
            button2.Name = "button2";
            button2.Size = new Size(24, 23);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 437);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            FormClosed += Registration_FormClosed;
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private Button button2;
    }
}