using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cursovaya3Kurs
{
    public partial class ReviewTestForm : MaterialForm
    {
        private List<Question> _questions;
        private List<int> _userAnswers; // хранит индекс выбранного пользователем ответа
        private int _currentQuestionIndex = 0;
        private List<RadioButton> _radioButtons;
        private int userId;
        private string username;
        int n = 0;

        public ReviewTestForm(List<Question> questions, List<int> userAnswers, int userId, string username)
        {
            InitializeComponent();
            label1.AutoEllipsis = true;
            this.userId = userId;
            this.username = username;
            _questions = questions;
            _userAnswers = userAnswers;
            _radioButtons = new List<RadioButton> { radioButton1, radioButton2, radioButton3, radioButton4 };

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {

            if (_currentQuestionIndex < _questions.Count)
            {
                var question = _questions[_currentQuestionIndex];
                label1.Text = question.Text;

                label1.MaximumSize = new Size(this.Width - 40, 0); // Устанавливаем максимальную ширину с учетом отступов
                label1.AutoSize = true; // Включаем автоматическое изменение размера по высоте

                for (int i = 0; i < _radioButtons.Count; i++)
                {
                    _radioButtons[i].Text = question.Options[i];
                    _radioButtons[i].Checked = false;
                    _radioButtons[i].Enabled = false;
                    _radioButtons[i].BackColor = Color.Transparent;

                    if (i == question.CorrectAnswerIndex)
                    {
                        _radioButtons[i].BackColor = Color.LightGreen; // правильный ответ зеленым
                    }
                    if (i == _userAnswers[_currentQuestionIndex])
                    {
                        _radioButtons[i].Checked = true;
                        if (i != question.CorrectAnswerIndex)
                        {
                            _radioButtons[i].BackColor = Color.LightCoral; // неправильный ответ красным
                        }
                    }
                }

                label4.Text = $"Вопрос: {_currentQuestionIndex + 1} из {_questions.Count}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n++;
            if (_currentQuestionIndex < _questions.Count - 1)
            {
                _currentQuestionIndex++;
                DisplayQuestion();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            if (_currentQuestionIndex > 0)
            {
                _currentQuestionIndex--;
                DisplayQuestion();
            }
        }

        private void ReviewTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            UserMenu userMenu = new UserMenu(userId, username);
            userMenu.Show();
            this.Close();
        }

        private void ReviewTestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
