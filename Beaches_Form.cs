using Peripatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Threading;

namespace Peripatos_UI
{
    public partial class Beaches_Form : Form
    {
        readonly SpeechSynthesizer synthesizer = new();
        public int Beach_Show_Index = 0;

        private List<byte[]> _slideshowImages = [];
        private int _currentImageIndex;

        public Beaches_Form()
        {
            InitializeComponent();
        }

        private void Beaches_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Beaches_Form_Load(object sender, EventArgs e)
        {
            StartCurrentBeachSlideShow();
            Check_if_Buttons_Enabled();
            ModifyStartStopVoiceButtons();
            Add_DropdownList_Items();
            Render_new_Beach_Data();
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.SpeakAsyncCancelAll();
            }
            Beach_Show_Index--;
            Check_if_Buttons_Enabled();
            Render_new_Beach_Data();

        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.SpeakAsyncCancelAll();
            }
            Beach_Show_Index++;
            Check_if_Buttons_Enabled();
            Render_new_Beach_Data();
        }

        private void Check_if_Buttons_Enabled()
        {
            if (Beach_Show_Index == 0)
            {
                button_Previous.Enabled = false;
                button_Next.Enabled = true;
            }
            else if (Beach_Show_Index > 0 && Beach_Show_Index < AppList_Manager.List_Beaches.Count - 1)
            {
                button_Previous.Enabled = true;
                button_Next.Enabled = true;
            }
            else
            {
                button_Previous.Enabled = true;
                button_Next.Enabled = false;
            }
        }

        private void Render_new_Beach_Data()
        {
            TextBox_PlaceTitle.Text = AppList_Manager.List_Beaches[Beach_Show_Index].Title;
            RichTextBox_PlaceDescription.Text = AppList_Manager.List_Beaches[Beach_Show_Index].Description;
            StartCurrentBeachSlideShow();
        }

        private void ModifyStartStopVoiceButtons()
        {
            //Text-to-voice (START) modifications
            button_StartVoice.FlatStyle = FlatStyle.Flat;
            button_StartVoice.FlatAppearance.BorderSize = 0;
            button_StartVoice.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_StartVoice.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_StartVoice.BackColor = Color.Transparent;
            button_StartVoice.ForeColor = Color.Transparent;
            button_StartVoice.Text = ""; // No text
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "start_voice_icon.jpg");
            button_StartVoice.Image = Image.FromFile(path);
            button_StartVoice.ImageAlign = ContentAlignment.MiddleCenter;
            button_StartVoice.TabStop = false;
            button_StartVoice.FlatAppearance.MouseOverBackColor = Color.LightGray;

            //Text-to-voice (STOP) modifications
            button_StopVoice.FlatStyle = FlatStyle.Flat;
            button_StopVoice.FlatAppearance.BorderSize = 0;
            button_StopVoice.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_StopVoice.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_StopVoice.BackColor = Color.Transparent;
            button_StopVoice.ForeColor = Color.Transparent;
            button_StopVoice.Text = ""; // No text
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "stop_voice_icon.jpg");
            button_StopVoice.Image = Image.FromFile(path);
            button_StopVoice.ImageAlign = ContentAlignment.MiddleCenter;
            button_StopVoice.TabStop = false;
            button_StopVoice.FlatAppearance.MouseOverBackColor = Color.LightGray;
        }

        private void button_StartVoice_Click(object sender, EventArgs e)
        {
            string text = AppList_Manager.List_Beaches[Beach_Show_Index].Description;
            synthesizer.SelectVoice("Microsoft Stefanos");
            synthesizer.SpeakAsyncCancelAll();
            synthesizer.SpeakAsync(text);
        }

        private void button_StopVoice_Click(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
        }

        private void button_BackToMenu_Click(object sender, EventArgs e)
        {
            //stop music
            synthesizer.SpeakAsyncCancelAll();
            //hide this form
            this.Hide();
            //show main menu
            new Main_Form().Show();
        }

        private void StartCurrentBeachSlideShow()
        {
            _slideshowImages = AppList_Manager.List_Beaches[Beach_Show_Index].Images;
            _currentImageIndex = -1;
            ShowNextImage();
            SildeshowTimer.Start();
        }

        private void ShowNextImage()
        {
            _currentImageIndex = (_currentImageIndex + 1) % _slideshowImages.Count;


            var oldImage = PictureBox_PlaceImage.Image;
            PictureBox_PlaceImage.Image = BytesToBitmapSafe(_slideshowImages[_currentImageIndex]);
            oldImage?.Dispose();
        }

        private static Bitmap BytesToBitmapSafe(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            using var temp = Image.FromStream(ms);
            return new Bitmap(temp);
        }

        private void SildeshowTimer_Tick(object sender, EventArgs e)
        {
            ShowNextImage();
        }

        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;

                Beach current_beach = AppList_Manager.List_Beaches[Beach_Show_Index];

                string beachFolder = Path.Combine(selectedPath, current_beach.Title);
                Directory.CreateDirectory(beachFolder);

                string beachImageFolder = Path.Combine(beachFolder, "Images");
                Directory.CreateDirectory(beachImageFolder);

                string infoFilePath = Path.Combine(beachFolder, $"{current_beach.Title}_Info.txt");
                string infoContent = $"Title: {current_beach.Title}{Environment.NewLine}{Environment.NewLine}Description:{Environment.NewLine}{current_beach.Description}";
                File.WriteAllText(infoFilePath, infoContent, Encoding.UTF8);

                string CoreBaseDir = Path.GetFullPath(
                Path.Combine(
                    Path.GetDirectoryName(typeof(Database).Assembly.Location)!,
                    @"..\..\..\..\Peripatos.Core"
                ));

                var sourceImagesDir = Path.Combine(CoreBaseDir, "Data", "Beach", "Images", $"{current_beach.Title}");

                if (Directory.Exists(sourceImagesDir))
                {
                    foreach (var srcPath in Directory.EnumerateFiles(sourceImagesDir, "*", SearchOption.AllDirectories))
                    {
                        string relative = Path.GetRelativePath(sourceImagesDir, srcPath);
                        string dstPath = Path.Combine(beachImageFolder, relative);
                        Directory.CreateDirectory(Path.GetDirectoryName(dstPath)!);
                        File.Copy(srcPath, dstPath, overwrite: true);
                    }
                }

            }
        }

        private void Add_DropdownList_Items()
        {
            Dropdown_Select_List.Items.Clear();
            foreach (var beach in AppList_Manager.List_Beaches)
            {
                Dropdown_Select_List.Items.Add(beach.Title);
            }
        }

        private void Dropdown_Select_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            synthesizer.SpeakAsyncCancelAll();
            int selected_index = Dropdown_Select_List.SelectedIndex;
            Beach_Show_Index = Dropdown_Select_List.SelectedIndex;
            Render_new_Beach_Data();
        }
    }
}
