﻿using Peripatos_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peripatos_UI
{
    public partial class Register_Form : Login_Form
    {
        public Register_Form()
        {
            InitializeComponent();
            //Delete some components from the main class that are not used here. These components are also protected for the childs to be able to access.
            this.Controls.Remove(this.LoginForm_Label_CreateUser);
            this.Controls.Remove(this.LoginForm_LinkLabel_CreateUserForm);
            this.Controls.Remove(this.LoginForm_Label_GuestForm);
            this.Controls.Remove(this.LoginForm_LinkLabel_GuestForm);

            //Button submit disabled by default
            Button_Submit.Enabled = false;

            //Settings for error
            errorProvider1.SetIconPadding(Textbox_Password, 2);
            errorProvider1.Icon = SystemIcons.Warning;
        }

        private void LoginForm_LinkLabel_GuestForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            //MainMenu mainmenu = new MainMenu();
            //mainmenu.Show();
        }

        private void Textbox_Password_TextChanged(object sender, EventArgs e)
        {
            string input_Password = Textbox_Password.Text;
            var error_messages = new List<string>();

            //More than 10 chars
            const string CheckLength10Chars = @"^.{10,}$";

            //More than 1 uppercase letter
            const string Check1UpperCase = @"[A-Z]";

            //More than 1 symbol
            const string Check1Symbol = @"[^A-Za-z0-9]";

            //More than 1 digit
            const string Check1Digit = @"\d";


            bool isCheckLength10Chars = Regex.IsMatch(input_Password, CheckLength10Chars);
            bool isCheck1UpperCase = Regex.IsMatch(input_Password, Check1UpperCase);
            bool isCheck1Symbol = Regex.IsMatch(input_Password, Check1Digit);
            bool isCheck1Digit = Regex.IsMatch(input_Password, Check1Symbol);

            if (!isCheckLength10Chars)
            {
                error_messages.Add("≥10 chars");
            }
            if (!isCheck1UpperCase)
            {
                error_messages.Add("an uppercase letter");
            }
            if (!isCheck1Symbol)
            {
                error_messages.Add("a digit");
            }
            if (!isCheck1Digit)
            {
                error_messages.Add("a symbol");
            }


            if (error_messages.Count != 0)
            {
                Button_Submit.Enabled = false;
                // show a single concatenated error message
                errorProvider1.SetError(Textbox_Password, "Password Requirements: " + string.Join(", ", error_messages));

                // color the TextBox background light red
                Textbox_Password.BackColor = Color.MistyRose;
            }
            else
            {
                Button_Submit.Enabled = true;

                // clear error and restore normal background
                errorProvider1.SetError(Textbox_Password, "");
                Textbox_Password.BackColor = SystemColors.Window;
            }

        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form login_form = new();
            login_form.Show();
        }

        private void Register_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Label_LoginTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
