namespace Cursovaya3Kurs
{
    public partial class UserStatistic : Form
    {
        private int userId;
        private string username;
        private UserStatistics userStatistics;

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
        }

        private void UserStatistic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }

    public class UserStatistics
    {
        public int UserId { get; set; }
        public int TotalTestsTaken { get; set; }
        public int TotalCorrectAnswers { get; set; }
        public int TotalQuestionsAnswered { get; set; }

        public UserStatistics(int userId)
        {
            UserId = userId;
            TotalTestsTaken = 0;
            TotalCorrectAnswers = 0;
            TotalQuestionsAnswered = 0;
        }

        public void Save(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(UserId);
                writer.WriteLine(TotalTestsTaken);
                writer.WriteLine(TotalCorrectAnswers);
                writer.WriteLine(TotalQuestionsAnswered);
            }
        }

        public static UserStatistics Load(string filePath)
        {
            if (!File.Exists(filePath)) return null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                int userId = int.Parse(reader.ReadLine());
                int totalTestsTaken = int.Parse(reader.ReadLine());
                int totalCorrectAnswers = int.Parse(reader.ReadLine());
                int totalQuestionsAnswered = int.Parse(reader.ReadLine());

                return new UserStatistics(userId)
                {
                    TotalTestsTaken = totalTestsTaken,
                    TotalCorrectAnswers = totalCorrectAnswers,
                    TotalQuestionsAnswered = totalQuestionsAnswered
                };
            }
        }
    }
}
