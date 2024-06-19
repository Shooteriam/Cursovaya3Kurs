using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cursovaya3Kurs
{
    public partial class StartTest : Form
    {
        private List<Question> _questions;
        private int _currentQuestionIndex = 0;
        private List<RadioButton> _radioButtons;
        private int _correctAnswersCount = 0;
        int n = 0;
        private int userId;
        private UserStatistics _userStatistics;

        private TimeSpan _timeRemaining = TimeSpan.FromMinutes(5); // 5 minutes countdown
        private DateTime _startTime;
        private bool _timeExpired = false;

        public StartTest(List<Question> questions, int userId)
        {
            InitializeComponent();
            this.userId = userId;
            _questions = questions;
            _radioButtons = new List<RadioButton> { radioButton1, radioButton2, radioButton3, radioButton4 };
            _userStatistics = UserStatistics.Load($"../../../Статистика/user_{userId}.txt") ?? new UserStatistics(userId);

            UpdateTimerLabel();

            timer1.Start();

            _startTime = DateTime.Now;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (_currentQuestionIndex < _questions.Count)
            {
                var question = _questions[_currentQuestionIndex];
                label1.Text = question.Text;
                for (int i = 0; i < _radioButtons.Count; i++)
                {
                    _radioButtons[i].Text = question.Options[i];
                    _radioButtons[i].Checked = false;
                }

                label4.Text = $"Вопрос: {_currentQuestionIndex + 1} из {_questions.Count}";
            }
            else
            {
                EndTest();
            }
        }

        private void EndTest()
        {
            timer1.Stop();

            if (!_timeExpired)
            {
                _userStatistics.TotalTestsTaken++;
                _userStatistics.TotalCorrectAnswers += _correctAnswersCount;
                _userStatistics.TotalQuestionsAnswered += _questions.Count;
                _userStatistics.Save($"../../../Статистика/user_{userId}.txt");
            }
            else
            {
                MessageBox.Show("Время вышло!");
            }

            MessageBox.Show($"Вы прошли все вопросы! Количество правильных ответов: {_correctAnswersCount} из {_questions.Count}.\nВремя прохождения: {(DateTime.Now - _startTime).Minutes} минут {(DateTime.Now - _startTime).Seconds} секунд.");

            n++;
            this.Close();
            ReturnToSelectTopic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedOptionIndex = -1;
            for (int i = 0; i < _radioButtons.Count; i++)
            {
                if (_radioButtons[i].Checked)
                {
                    selectedOptionIndex = i;
                    break;
                }
            }

            if (selectedOptionIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите вариант ответа.");
                return;
            }

            var correctAnswerIndex = _questions[_currentQuestionIndex].CorrectAnswerIndex;

            if (selectedOptionIndex == correctAnswerIndex)
            {
                _correctAnswersCount++;
            }

            _currentQuestionIndex++;
            DisplayQuestion();
        }

        private void ReturnToSelectTopic()
        {
            var selectTopicForm = new SelectTopic(userId);
            selectTopicForm.Show();
        }

        private void StartTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private void StartTest_Load(object sender, EventArgs e)
        {
            label2.Text = $"id: {userId.ToString()}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeRemaining = _timeRemaining.Subtract(TimeSpan.FromSeconds(1));
            UpdateTimerLabel();

            if (_timeRemaining.TotalSeconds <= 0)
            {
                EndTest();
            }
        }

        private void UpdateTimerLabel()
        {
            label3.Text = $"Осталось: {_timeRemaining:mm\\:ss}";
        }
    }
}
