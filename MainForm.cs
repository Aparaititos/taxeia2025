namespace taxeia2025
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label_tour_odigos_Click(object sender, EventArgs e)
        {

        }
        private void button_register_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {

        }

        private void button_guest_Click(object sender, EventArgs e)
        {

        }

        private void σχετικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός\nDeveloped by ’γγελος Μπερκέτης και Βασίλης Νεοκοσμίδης", "Σχετικά", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Σύνδεση μενού με τα κουμπιά
        private void εγγραφήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_register.PerformClick();
        }

        private void είσοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_login.PerformClick();
        }

        private void αποσύνδεσηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_logout.PerformClick();
        }

        private void σύνδεσηΕπισκέπτηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_guest.PerformClick();
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
