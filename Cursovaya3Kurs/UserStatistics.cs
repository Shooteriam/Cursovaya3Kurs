using System;
using System.IO;

namespace Cursovaya3Kurs
{
    public class UserStatistics
    {
        public int UserId { get; set; }
        public int TotalTestsTaken { get; set; }
        public int TotalCorrectAnswers { get; set; }
        public int TotalQuestionsAnswered { get; set; }
        public TimeSpan TotalTimeSpent { get; set; } // поле для хранения общего времени

        public UserStatistics(int userId)
        {
            UserId = userId;
            TotalTestsTaken = 0;
            TotalCorrectAnswers = 0;
            TotalQuestionsAnswered = 0;
            TotalTimeSpent = TimeSpan.Zero;
        }

        public void Save(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(UserId);
                writer.WriteLine(TotalTestsTaken);
                writer.WriteLine(TotalCorrectAnswers);
                writer.WriteLine(TotalQuestionsAnswered);
                writer.WriteLine(TotalTimeSpent.TotalSeconds); // Сохраняем общее время в секундах
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

                // Проверка на null и установка значения по умолчанию
                string totalTimeSpentStr = reader.ReadLine();
                double totalTimeSpentSeconds = string.IsNullOrEmpty(totalTimeSpentStr) ? 0 : double.Parse(totalTimeSpentStr);

                return new UserStatistics(userId)
                {
                    TotalTestsTaken = totalTestsTaken,
                    TotalCorrectAnswers = totalCorrectAnswers,
                    TotalQuestionsAnswered = totalQuestionsAnswered,
                    TotalTimeSpent = TimeSpan.FromSeconds(totalTimeSpentSeconds) // Восстанавливаем общее время из секунд
                };
            }
        }
    }
}
