using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WallpaperChanger
{
    public partial class ram_I : Form
    {
        public ram_I()
        {
            InitializeComponent();
            DisplayRamInfo();
        }

        private void DisplayRamInfo()
        {
            // Get RAM information
            var ramInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            long totalRam = (long)ramInfo.TotalPhysicalMemory;

            // Display RAM information
            Label ramLabel = new Label { Text = $"Total RAM: {totalRam / (1024 * 1024)} MB", Dock = DockStyle.Fill };
            this.Controls.Add(ramLabel);
        }
    }
}
