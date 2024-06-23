using ClosedXML.Excel;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cursovaya3Kurs
{
    public partial class AllStatistic : MaterialForm
    {
        int n = 0;
        private int userId;
        private string username;

        public AllStatistic(int userId, string username)
        {
            InitializeComponent();
            LoadStatistics();
            this.userId = userId;
            this.username = username;
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
                    dataGridView1.Rows.Add(stats.UserId, stats.TotalTestsTaken, stats.TotalCorrectAnswers, stats.TotalQuestionsAnswered, stats.TotalTimeSpent);
                }
            }
        }

        private void ViewStatistics_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("userId", "ID пользователя");
            dataGridView1.Columns.Add("totalTestsTaken", "Всего пройдено тестов");
            dataGridView1.Columns.Add("totalCorrectAnswers", "Всего правильных ответов");
            dataGridView1.Columns.Add("totalQuestionsAnswered", "Всего отвечено вопросов");
            dataGridView1.Columns.Add("TotalTimeSpent", "Всего времени за тестами");
        }

        private void AllStatistic_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void AllStatistic_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n++;
            AdminMenu adminMenu = new AdminMenu(userId, username);
            adminMenu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // экспорт в excel
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Статистика");

                // Заголовки
                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cell(1, i).Value = dataGridView1.Columns[i - 1].HeaderText;
                }

                // Данные
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Выбор места сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "Статистика.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Данные успешно экспортированы в Excel!", "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
