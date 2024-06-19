namespace Cursovaya3Kurs
{
    public partial class AdminMenu : Form
    {
        private int userId;
        int n = 0;

        public AdminMenu(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            label1.Text = $"id: {userId.ToString()}";
        }

        private void button1_Click(object sender, EventArgs e) // редактировать теорию
        {
            n++;
            Theory theory = new Theory(true, userId);
            theory.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            EditTest editTest = new EditTest(userId);
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
            AllStatistic allStatistic = new AllStatistic();
            allStatistic.Show();
            this.Close();
        }
    }
}
