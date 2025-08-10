using Peripatos_UI;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Peripatos.Core;

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

        protected void Button_Submit_Click(object? sender, EventArgs e)
        {

            bool userExists = Database.Select_User(Textbox_Username.Text, Textbox_Password.Text);

            if (userExists)
            {
                MessageBox.Show(
                    $"Welcome {Textbox_Username.Text}"
                );
                return;
            }
            else
            {
                MessageBox.Show(
                    $"Username or password are incorrect please try again."
                );
                return;
            }

            //this.Close();
            //Login_Form main_menu = new();
            //main_menu.Show();
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new Main_Form().Show();
        }
    }
}
