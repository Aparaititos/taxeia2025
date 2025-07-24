using Peripatos_UI;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Peripatos_UI
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void LoginForm_LinkLabel_CreateUserForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register_Form register_form = new();
            register_form.Show();
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Login_Form main_menu = new();
            //main_menu.Show();
        }
    }
}
