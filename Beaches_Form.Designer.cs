namespace Peripatos_UI
{
    partial class Beaches_Form
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
            PictureBox_PlaceImage = new PictureBox();
            TextBox_PlaceTitle = new TextBox();
            RichTextBox_PlaceDescription = new RichTextBox();
            button_Previous = new Button();
            button_Next = new Button();
            button_StartVoice = new Button();
            button_StopVoice = new Button();
            button_BackToMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox_PlaceImage).BeginInit();
            SuspendLayout();
            // 
            // PictureBox_PlaceImage
            // 
            PictureBox_PlaceImage.Location = new Point(12, 37);
            PictureBox_PlaceImage.Name = "PictureBox_PlaceImage";
            PictureBox_PlaceImage.Size = new Size(647, 356);
            PictureBox_PlaceImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_PlaceImage.TabIndex = 0;
            PictureBox_PlaceImage.TabStop = false;
            // 
            // TextBox_PlaceTitle
            // 
            TextBox_PlaceTitle.Location = new Point(12, 12);
            TextBox_PlaceTitle.Name = "TextBox_PlaceTitle";
            TextBox_PlaceTitle.Size = new Size(647, 23);
            TextBox_PlaceTitle.TabIndex = 1;
            // 
            // RichTextBox_PlaceDescription
            // 
            RichTextBox_PlaceDescription.Location = new Point(12, 399);
            RichTextBox_PlaceDescription.Name = "RichTextBox_PlaceDescription";
            RichTextBox_PlaceDescription.Size = new Size(647, 140);
            RichTextBox_PlaceDescription.TabIndex = 2;
            RichTextBox_PlaceDescription.Text = "";
            // 
            // button_Previous
            // 
            button_Previous.Location = new Point(689, 425);
            button_Previous.Name = "button_Previous";
            button_Previous.Size = new Size(92, 42);
            button_Previous.TabIndex = 3;
            button_Previous.Text = "Previous";
            button_Previous.UseVisualStyleBackColor = true;
            button_Previous.Click += Button_Previous_Click;
            // 
            // button_Next
            // 
            button_Next.Location = new Point(844, 425);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(93, 42);
            button_Next.TabIndex = 4;
            button_Next.Text = "Next";
            button_Next.UseVisualStyleBackColor = true;
            button_Next.Click += button_Next_Click;
            // 
            // button_StartVoice
            // 
            button_StartVoice.Location = new Point(689, 351);
            button_StartVoice.Name = "button_StartVoice";
            button_StartVoice.Size = new Size(106, 54);
            button_StartVoice.TabIndex = 5;
            button_StartVoice.Text = "Start Voice Button";
            button_StartVoice.UseVisualStyleBackColor = true;
            button_StartVoice.Click += button_StartVoice_Click;
            // 
            // button_StopVoice
            // 
            button_StopVoice.Location = new Point(844, 351);
            button_StopVoice.Name = "button_StopVoice";
            button_StopVoice.Size = new Size(104, 54);
            button_StopVoice.TabIndex = 6;
            button_StopVoice.Text = "Stop Voice Button";
            button_StopVoice.UseVisualStyleBackColor = true;
            button_StopVoice.Click += button_StopVoice_Click;
            // 
            // button_BackToMenu
            // 
            button_BackToMenu.Location = new Point(689, 12);
            button_BackToMenu.Name = "button_BackToMenu";
            button_BackToMenu.Size = new Size(134, 54);
            button_BackToMenu.TabIndex = 7;
            button_BackToMenu.Text = "Back to Main Menu";
            button_BackToMenu.UseVisualStyleBackColor = true;
            button_BackToMenu.Click += button_BackToMenu_Click;
            // 
            // Beaches_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 545);
            Controls.Add(button_BackToMenu);
            Controls.Add(button_StopVoice);
            Controls.Add(button_StartVoice);
            Controls.Add(button_Next);
            Controls.Add(button_Previous);
            Controls.Add(RichTextBox_PlaceDescription);
            Controls.Add(TextBox_PlaceTitle);
            Controls.Add(PictureBox_PlaceImage);
            Name = "Beaches_Form";
            Text = "Beaches_Form";
            FormClosed += Beaches_Form_FormClosed;
            Load += Beaches_Form_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox_PlaceImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureBox_PlaceImage;
        private TextBox TextBox_PlaceTitle;
        private RichTextBox RichTextBox_PlaceDescription;
        private Button button_Previous;
        private Button button_Next;
        private Button button_StartVoice;
        private Button button_StopVoice;
        private Button button_BackToMenu;
    }
}