using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;

namespace Cursovaya3Kurs
{
    public partial class Form1 : MaterialForm
    {
        private OleDbConnection connection;
        int n = 0;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

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
                    AdminMenu adminMenu = new AdminMenu(userId, username);
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
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUser(string username, string password, out int userId, out string role, out string validatedUsername)
        {
            userId = -1;
            role = string.Empty;
            validatedUsername = string.Empty;

            string query = "SELECT ID, Username, Role FROM Пользователи WHERE StrComp(Username, @Username, 0) = 0 AND [Password] = @Password";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
