using System.Data.OleDb;

namespace Cursovaya3Kurs
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection;
        int n = 0;

        public Form1()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Users.accdb;";
            connection = new OleDbConnection(connectionString);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (ValidateUser(username, password, out int userId, out string role, out string validatedUsername))
            {
                if (role == "admin")
                {
                    AdminMenu adminMenu = new AdminMenu(userId);
                    adminMenu.Show();
                }
                else
                {
                    UserMenu userMenu = new UserMenu(userId, validatedUsername);
                    userMenu.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private bool ValidateUser(string username, string password, out int userId, out string role, out string validatedUsername)
        {
            userId = -1;
            role = string.Empty;
            validatedUsername = string.Empty;
            string query = "SELECT ID, Username, Role FROM Пользователи WHERE Username = @Username AND [Password] = @Password";
            using (OleDbCommand cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userId = Convert.ToInt32(reader["ID"]);
                    role = reader["Role"].ToString();
                    validatedUsername = reader["Username"].ToString();
                    reader.Close();
                    connection.Close();
                    return true;
                }
                reader.Close();
                connection.Close();
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
