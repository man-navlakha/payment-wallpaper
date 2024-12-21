using System;
using System.Drawing;
using System.Windows.Forms;

namespace WallpaperChanger
{
    public partial class test : Form
    {
        private Color[] colors = new Color[36];
        private int currentColorIndex = 0;

        public test()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Remove borders
            this.WindowState = FormWindowState.Maximized; // Full screen
            InitializeColors();
            this.KeyDown += new KeyEventHandler(test_KeyDown);
            this.Load += new EventHandler(test_Load);
        }

        private void InitializeColors()
        {
            // Initialize an array of 36 colors
            colors[0] = Color.DarkRed;
            colors[1] = Color.Red;
            colors[2] = Color.LightCoral; // Light Red
            colors[3] = Color.OrangeRed;
            colors[4] = Color.Pink;

            colors[5] = Color.DarkGreen;
            colors[6] = Color.Green;
            colors[7] = Color.LightGreen;
            colors[8] = Color.Lime;
            colors[9] = Color.Teal;

            colors[10] = Color.DarkBlue;
            colors[11] = Color.Blue;
            colors[12] = Color.LightBlue;
            colors[13] = Color.SkyBlue;
            colors[14] = Color.Indigo;

            colors[15] = Color.DarkCyan;
            colors[16] = Color.LightCyan;

            colors[17] = Color.DarkMagenta;
            colors[18] = Color.FromArgb(255, 182, 193);

            colors[19] = Color.DarkGoldenrod; // Dark Yellow
            colors[20] = Color.Gold; // Golden Yellow
            colors[21] = Color.LightGoldenrodYellow; // Light Yellow

            colors[22] = Color.Black;
            colors[23] = Color.DarkGray;
            colors[24] = Color.Gray; // Medium Gray
            colors[25] = Color.LightGray;
            colors[26] = Color.White;

            // Skin tones (approximate)
            colors[27] = Color.FromArgb(255, 224, 189); // Light Skin Tone
            colors[28] = Color.FromArgb(224, 172, 105); // Medium Light Skin Tone
            colors[29] = Color.FromArgb(184, 134, 11); // Medium Skin Tone
            colors[30] = Color.FromArgb(139, 69, 19); // Dark Skin Tone
            colors[31] = Color.FromArgb(255, 204, 204); // Light Pink Skin Tone

            // Additional colors
            colors[32] = Color.Brown;
            colors[33] = Color.Violet;
            colors[34] = Color.Orange;
            colors[35] = Color.Purple; // Additional color

        }

        private void test_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // Change color every second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.BackColor = colors[currentColorIndex];
            currentColorIndex = (currentColorIndex + 1) % colors.Length; // Loop through colors
        }

        private void test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Close the test form
                Application.OpenForms[0].Show(); // Show the home form again
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the test form
            Application.OpenForms[0].Show(); // Show the home form again  
        }
    }
}