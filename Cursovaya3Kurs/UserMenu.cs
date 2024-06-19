﻿namespace Cursovaya3Kurs
{
    public partial class UserMenu : Form
    {
        private int userId;
        private string username;

        int n = 0;

        public UserMenu(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            label1.Text = $"id: {userId.ToString()}";
        }

        private void button1_Click(object sender, EventArgs e) // теория
        {
            n++;
            Theory theory = new Theory(false, userId);
            theory.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // пройти тесты
        {
            n++;
            SelectTopic selectTopic = new SelectTopic(userId);
            selectTopic.Show();
            this.Close();
        }

        private void UserMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            UserStatistic userStatistic = new UserStatistic(userId, username);
            userStatistic.Show();
            this.Close();
        }
    }
}
