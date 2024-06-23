using MaterialSkin.Controls;


namespace Cursovaya3Kurs
{
    public partial class TestResultForm : MaterialForm
    {
        private int _correctAnswersCount;
        private int _totalQuestions;
        private TimeSpan _testDuration;
        private List<Question> _questions;
        private List<int> _userAnswers;
        private int userId;
        private string username;
        int n = 0;

        public TestResultForm(int correctAnswersCount, int totalQuestions, TimeSpan testDuration, List<Question> questions, List<int> userAnswers, int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
            _correctAnswersCount = correctAnswersCount;
            _totalQuestions = totalQuestions;
            _testDuration = testDuration;
            _questions = questions;
            _userAnswers = userAnswers;
            DisplayResults();
        }

        private void DisplayResults()
        {
            label1.Text = $"Вы ответили на все вопросы! \n" +
                $"Количество правильных ответов: {_correctAnswersCount} из {_totalQuestions}.\n" +
                $"Время прохождения: {_testDuration.Minutes} минут {_testDuration.Seconds} секунд.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n++;
            UserMenu userMenu = new UserMenu(userId, username);
            userMenu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            var reviewForm = new ReviewTestForm(_questions, _userAnswers, userId, username);
            reviewForm.Show();
            this.Close();
        }

        private void TestResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }
    }
}
