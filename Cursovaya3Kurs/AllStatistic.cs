using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursovaya3Kurs
{
    public partial class AllStatistic : Form
    {
        public AllStatistic()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            string statsPath = @"../../../Статистика";

            if (!Directory.Exists(statsPath))
            {
                MessageBox.Show("Папка со статистикой не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var statFiles = Directory.GetFiles(statsPath, "*.txt");

            foreach (var file in statFiles)
            {
                var stats = UserStatistics.Load(file);
                if (stats != null)
                {
                    dataGridView1.Rows.Add(stats.UserId, stats.TotalTestsTaken, stats.TotalQuestionsAnswered, stats.TotalCorrectAnswers);
                }
            }
        }

        private void ViewStatistics_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("userId", "ID пользователя");
            dataGridView1.Columns.Add("totalTestsTaken", "Всего пройдено тестов");
            dataGridView1.Columns.Add("totalQuestionsAnswered", "Всего отвечено вопросов");
            dataGridView1.Columns.Add("totalCorrectAnswers", "Всего правильных ответов");
        }

        private void AllStatistic_Load(object sender, EventArgs e)
        {

        }

        private void AllStatistic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
