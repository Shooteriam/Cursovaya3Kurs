using MaterialSkin.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursovaya3Kurs
{
    public partial class EditTest : MaterialForm
    {
        private int userId;
        private string username;
        int n = 0;

        public EditTest(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
        }

        private void EditTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string basePath = @"../../../Тесты";

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

        private void EditTest_Load(object sender, EventArgs e)
        {

            string basePath = @"../../../Тесты";

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
                    }
                }
                else
                {
                    MessageBox.Show($"Файл {filePath} не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n++;
            AdminMenu adminMenu = new AdminMenu(userId, username);
            adminMenu.Show();
            this.Close();
        }
    }
}
