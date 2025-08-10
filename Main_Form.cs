using Peripatos.Core;
namespace Peripatos_UI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void label_tour_odigos_Click(object sender, EventArgs e)
        {

        }
        private void button_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register_Form().Show();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Form().Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {

        }

        private void button_guest_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός\nDeveloped by ’γγελος Μπερκέτης και Βασίλης Νεοκοσμίδης", "Σχετικά", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Σύνδεση μενού με τα κουμπιά
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_register.PerformClick();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_login.PerformClick();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_logout.PerformClick();
        }

        private void guestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_guest.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_beaches_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Beaches_Form().Show();
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
