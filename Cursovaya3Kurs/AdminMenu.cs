using MaterialSkin.Controls;

namespace Cursovaya3Kurs
{
    public partial class AdminMenu : MaterialForm
    {
        private int userId;
        private string username;

        int n = 0;

        public AdminMenu(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            label1.Text = $"id: {userId.ToString()}";
        }

        private void button1_Click(object sender, EventArgs e) // редактировать теорию
        {
            n++;
            Theory theory = new Theory(true, userId, username);
            theory.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            EditTest editTest = new EditTest(userId, username);
            editTest.Show();
            this.Close();
        }

        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (n == 0)
            {
                Application.OpenForms[0].Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            AllStatistic allStatistic = new AllStatistic(userId, username);
            allStatistic.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n++;
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
