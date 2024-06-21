using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursovaya3Kurs
{
    public partial class Registration : MaterialForm
    {
        private OleDbConnection connection;
        private const string adminPassword = "admin"; // Пароль для регистрации администратора

        public Registration()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Users.accdb;";
            connection = new OleDbConnection(connectionString);
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;
            bool isAdmin = checkBox1.Checked;

            //if (password != confirmPassword)
            //{
            //    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UserExists(username))
            {
                MessageBox.Show("Пользователь с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isAdmin)
            {
                string adminPasswordInput = textBox4.Text;
                if (adminPasswordInput != adminPassword)
                {
                    MessageBox.Show("Неверный пароль администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            AddUserToDatabase(username, password, isAdmin);
            MessageBox.Show("Регистрация успешна", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private bool UserExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Пользователи WHERE Username = @Username";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);

            connection.Open();
            int count = (int)cmd.ExecuteScalar();
            connection.Close();

            return count > 0;
        }

        private void AddUserToDatabase(string username, string password, bool isAdmin)
        {
            string role = isAdmin ? "admin" : "user";
            string query = "INSERT INTO Пользователи (Username, [Password], [Role]) VALUES (@Username, @Password, @Role)";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", role);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox1.Checked;
            textBox4.Visible = isChecked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
            textBox3.UseSystemPasswordChar = !textBox3.UseSystemPasswordChar;
        }
    }
}
