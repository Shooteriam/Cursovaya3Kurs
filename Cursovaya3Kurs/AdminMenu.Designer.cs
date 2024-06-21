namespace Cursovaya3Kurs
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(524, 36);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "id: -";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(166, 156);
            button1.Name = "button1";
            button1.Size = new Size(233, 34);
            button1.TabIndex = 2;
            button1.Text = "Редактировать теорию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button2.Location = new Point(166, 196);
            button2.Name = "button2";
            button2.Size = new Size(233, 34);
            button2.TabIndex = 3;
            button2.Text = "Редактировать тесты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            button3.Location = new Point(166, 236);
            button3.Name = "button3";
            button3.Size = new Size(233, 34);
            button3.TabIndex = 4;
            button3.Text = "Просмотр статистики";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.free_icon_log_out_4662171;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(12, 338);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 382);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню администратора";
            FormClosing += AdminMenu_FormClosing;
            Load += AdminMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}