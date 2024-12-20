using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq; // Make sure to install Newtonsoft.Json via NuGet

namespace WallpaperChanger
{
    public partial class Form1 : Form
    {
        private const string ApiUrl = "http://localhost/api.php?id=user123";
        private const string WallpaperUrl = "https://images.pexels.com/photos/2387793/pexels-photo-2387793.jpeg";

        public Form1()
        {
            InitializeComponent();
            this.Hide(); // Hide the form notifyIcon1.Visible = true; // Show the notify icon
            timer1.Interval = 60000; // Set the timer interval to 1 minute (60000 ms)
            timer1.Tick += Timer1_Tick; // Subscribe to the Tick event
            timer1.Start(); // Start the timer
        }


        // Add this method to handle the exit option in the context menu
        private void exITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Status: Checking...";
            var isLocked = await CheckWallpaperStatusAsync();
            if (isLocked)
            {
                ChangeWallpaper(WallpaperUrl);
                label1.Text = "Status: Wallpaper Changed!";
            }
            else
            {
                label1.Text = "Status: No Change Needed.";
            }
        }

        private async Task<bool> CheckWallpaperStatusAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(ApiUrl);
                var json = JObject.Parse(response);
                return json["is_locked"].ToString() == "1";
            }
        }

        private void ChangeWallpaper(string url)
        {
            using (var webClient = new System.Net.WebClient())
            {
                string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "wallpaper.jpg");
                webClient.DownloadFile(url, filePath);
                SetWallpaper(filePath);
            }
        }

        private void SetWallpaper(string path)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        }

        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDCHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }
    }
}