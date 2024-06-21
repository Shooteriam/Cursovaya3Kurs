using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Cursovaya3Kurs
{
    public partial class UserStatistic : MaterialForm
    {
        private int userId;
        private string username;
        private UserStatistics userStatistics;
        int n = 0;

        public UserStatistic(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            userStatistics = UserStatistics.Load($"../../../Статистика/user_{userId}.txt") ?? new UserStatistics(userId);
        }

        private void UserStatistic_Load(object sender, EventArgs e)
        {
            label1.Text = $"Имя пользователя: {username} (id: {userId.ToString()})";
            label2.Text = $"Количество пройденных тестов: {userStatistics.TotalTestsTaken}";
            label3.Text = $"Общее количество правильных ответов: {userStatistics.TotalCorrectAnswers}";
            label4.Text = $"Общее количество отвеченных вопросов: {userStatistics.TotalQuestionsAnswered}";
            label5.Text = $"Общее время за тестами: {userStatistics.TotalTimeSpent.Hours} часов {userStatistics.TotalTimeSpent.Minutes} минут {userStatistics.TotalTimeSpent.Seconds} секунд"; // Новая метка для общего времени
        }

        private void UserStatistic_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            UserMenu userMenu = new UserMenu(userId, username);
            userMenu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userStatistics.TotalTestsTaken = 0;
            userStatistics.TotalCorrectAnswers = 0;
            userStatistics.TotalQuestionsAnswered = 0;
            userStatistics.TotalTimeSpent = TimeSpan.Zero;

            // Сохранение сброшенной статистики в файл
            userStatistics.Save($"../../../Статистика/user_{userId}.txt");

            // Обновление меток
            label2.Text = $"Количество пройденных тестов: {userStatistics.TotalTestsTaken}";
            label3.Text = $"Общее количество правильных ответов: {userStatistics.TotalCorrectAnswers}";
            label4.Text = $"Общее количество отвеченных вопросов: {userStatistics.TotalQuestionsAnswered}";
            label5.Text = $"Общее время за тестами: {userStatistics.TotalTimeSpent.Hours} часов {userStatistics.TotalTimeSpent.Minutes} минут {userStatistics.TotalTimeSpent.Seconds} секунд"; // Обновление метки общего времени

            // Уведомление пользователя о сбросе статистики
            MessageBox.Show("Статистика была сброшена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
