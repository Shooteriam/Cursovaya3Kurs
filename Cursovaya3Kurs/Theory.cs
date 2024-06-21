using MaterialSkin.Controls;

namespace Cursovaya3Kurs
{
    public partial class Theory : MaterialForm
    {
        public bool IsAdmin { get; set; } // Свойство для проверки, является ли пользователь администратором
        private int userId;
        private string username;
        int n = 0;

        public Theory(bool isAdmin, int userId, string username)
        {
            InitializeComponent();
            IsAdmin = isAdmin;
            this.userId = userId;
            this.username = username;
        }

        private void Theory_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private void Theory_Load(object sender, EventArgs e)
        {
            label1.Text = $"id: {userId.ToString()}";

            string basePath = @"../../../Теория";

            string[] fileNames = {
                "Определение структуры.txt",
                "Создание объекта структуры.txt",
                "Инициализация полей по умолчанию.txt",
                "Конструкторы структуры.txt",
                "Инициализатор структуры.txt",
                "Копирование структуры с помощью with.txt"
            };

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                string filePath = Path.Combine(basePath, fileNames[i]);

                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);

                    TextBox textBox = tabControl1.TabPages[i].Controls.OfType<TextBox>().FirstOrDefault();
                    if (textBox != null)
                    {
                        textBox.Text = content;
                        textBox.ReadOnly = !IsAdmin; // Только администраторы могут редактировать текст
                    }
                }
                else
                {
                    MessageBox.Show($"Файл {filePath} не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            button1.Visible = IsAdmin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string basePath = @"../../../Теория";

            string[] fileNames = {
                "Определение структуры.txt",
                "Создание объекта структуры.txt",
                "Инициализация полей по умолчанию.txt",
                "Конструкторы структуры.txt",
                "Инициализатор структуры.txt",
                "Копирование структуры с помощью with.txt"
            };

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                string filePath = Path.Combine(basePath, fileNames[i]);
                TextBox textBox = tabControl1.TabPages[i].Controls.OfType<TextBox>().FirstOrDefault();
                if (textBox != null)
                {
                    File.WriteAllText(filePath, textBox.Text);
                }
            }

            MessageBox.Show("Изменения сохранены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                n++;
                AdminMenu adminMenu = new AdminMenu(userId, username);
                adminMenu.Show();
                this.Close();
            }
            else
            {
                n++;
                UserMenu userMenu = new UserMenu(userId, username);
                userMenu.Show();
                this.Close();
            }
        }
    }
}
