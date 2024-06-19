using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cursovaya3Kurs
{
    public partial class SelectTopic : Form
    {
        int n = 0;
        private int userId;

        public SelectTopic(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void SelectTopic_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private List<Question> LoadTest(string filePath)
        {
            var questions = new List<Question>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 5)
                {
                    var questionText = parts[0];
                    var options = new List<string> { parts[1], parts[2], parts[3], parts[4] };
                    var correctAnswerIndex = options.FindIndex(o => o.StartsWith("*"));

                    if (correctAnswerIndex != -1)
                    {
                        options[correctAnswerIndex] = options[correctAnswerIndex].TrimStart('*');
                    }

                    questions.Add(new Question
                    {
                        Text = questionText,
                        Options = options,
                        CorrectAnswerIndex = correctAnswerIndex
                    });
                }
            }

            return questions;
        }

        private List<Question> LoadAllTests()
        {
            var allQuestions = new List<Question>();
            var topicFiles = new string[]
            {
                "../../../Тесты/Определение структуры.txt",
                "../../../Тесты/Создание объекта структуры.txt",
                "../../../Тесты/Инициализация полей по умолчанию.txt",
                "../../../Тесты/Конструкторы структуры.txt",
                "../../../Тесты/Инициализатор структуры.txt",
                "../../../Тесты/Копирование структуры с помощью with.txt"
            };

            foreach (var file in topicFiles)
            {
                allQuestions.AddRange(LoadTest(file));
            }

            return allQuestions;
        }

        private List<Question> GetRandomQuestions(List<Question> questions, int count)
        {
            var random = new Random();
            return questions.OrderBy(x => random.Next()).Distinct().Take(count).ToList();
        }

        private void OpenTestForm(string filePath)
        {
            var questions = LoadTest(filePath);
            var testForm = new StartTest(questions, userId);
            testForm.Show();
            this.Close();
        }

        private void OpenRandomTestForm()
        {
            var allQuestions = LoadAllTests();
            var randomQuestions = GetRandomQuestions(allQuestions, 15);
            var testForm = new StartTest(randomQuestions, userId);
            testForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n++;
            OpenTestForm("../../../Тесты/Определение структуры.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            OpenTestForm("../../../Тесты/Создание объекта структуры.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            OpenTestForm("../../../Тесты/Инициализация полей по умолчанию.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n++;
            OpenTestForm("../../../Тесты/Конструкторы структуры.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n++;
            OpenTestForm("../../../Тесты/Инициализатор структуры.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n++;
            OpenTestForm("../../../Тесты/Копирование структуры с помощью with.txt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n++;
            OpenRandomTestForm();
        }

        private void SelectTopic_Load(object sender, EventArgs e)
        {
            label1.Text = $"id: {userId.ToString()}";
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }
}
