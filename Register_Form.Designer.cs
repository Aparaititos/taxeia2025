namespace Peripatos_UI
{
    partial class Register_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Label_LoginTitle
            // 
            Label_LoginTitle.Size = new Size(341, 45);
            Label_LoginTitle.Text = "Register to \"Peripatos\"";
            // 
            // LoginForm_LinkLabel_GuestForm
            // 
            LoginForm_LinkLabel_GuestForm.LinkClicked += LoginForm_LinkLabel_GuestForm_LinkClicked;
            // 
            // Button_Submit
            // 
            Button_Submit.Text = "Register";
            Button_Submit.Click += Button_Submit_Click;
            // 
            // Textbox_Password
            // 
            Textbox_Password.TextChanged += Textbox_Password_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Register_Form";
            Text = "Peripatos - Register";
            FormClosed += Register_Form_FormClosed;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
    }
}