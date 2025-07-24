namespace Peripatos_UI
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            guestToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label_tour_odigos = new Label();
            button_register = new Button();
            button_login = new Button();
            button_logout = new Button();
            button_guest = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, loginToolStripMenuItem, logoutToolStripMenuItem, guestToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(70, 24);
            fileToolStripMenuItem.Text = "Αρχείο";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(224, 26);
            registerToolStripMenuItem.Text = "Εγγραφή";
            registerToolStripMenuItem.Click += εγγραφήToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(224, 26);
            loginToolStripMenuItem.Text = "Σύνδεση";
            loginToolStripMenuItem.Click += είσοδοςToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Αποσύνδεση";
            logoutToolStripMenuItem.Click += αποσύνδεσηToolStripMenuItem_Click;
            // 
            // guestToolStripMenuItem
            // 
            guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            guestToolStripMenuItem.Size = new Size(224, 26);
            guestToolStripMenuItem.Text = "Σύνδεση Επισκέπτη";
            guestToolStripMenuItem.Click += σύνδεσηΕπισκέπτηToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Έξοδος";
            exitToolStripMenuItem.Click += έξοδοςToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(79, 24);
            helpToolStripMenuItem.Text = "Βοήθεια";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "Σχετικά...";
            aboutToolStripMenuItem.Click += σχετικάToolStripMenuItem_Click;
            // 
            // label_tour_odigos
            // 
            label_tour_odigos.AutoSize = true;
            label_tour_odigos.Location = new Point(307, 28);
            label_tour_odigos.Name = "label_tour_odigos";
            label_tour_odigos.Size = new Size(148, 20);
            label_tour_odigos.TabIndex = 1;
            label_tour_odigos.Text = "Τουριστικός Οδηγός";
            label_tour_odigos.Click += label_tour_odigos_Click;
            // 
            // button_register
            // 
            button_register.Location = new Point(20, 48);
            button_register.Name = "button_register";
            button_register.Size = new Size(110, 29);
            button_register.TabIndex = 2;
            button_register.Text = "Εγγραφή Χρήστη";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // button_login
            // 
            button_login.Location = new Point(20, 83);
            button_login.Name = "button_login";
            button_login.Size = new Size(110, 29);
            button_login.TabIndex = 3;
            button_login.Text = "Σύνδεση";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_logout
            // 
            button_logout.Location = new Point(20, 118);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(110, 29);
            button_logout.TabIndex = 4;
            button_logout.Text = "Αποσύνδεση";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // button_guest
            // 
            button_guest.Location = new Point(20, 153);
            button_guest.Name = "button_guest";
            button_guest.Size = new Size(110, 29);
            button_guest.TabIndex = 5;
            button_guest.Text = "Επισκέπτης";
            button_guest.UseVisualStyleBackColor = true;
            button_guest.Click += button_guest_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_guest);
            Controls.Add(button_logout);
            Controls.Add(button_login);
            Controls.Add(button_register);
            Controls.Add(label_tour_odigos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main_Form";
            Text = "Τουριστικός Οδηγός";
            Load += Main_Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem guestToolStripMenuItem;
        private Label label_tour_odigos;
        private Button button_register;
        private Button button_login;
        private Button button_logout;
        private Button button_guest;
    }
}
