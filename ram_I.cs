using System;
using System.Windows.Forms;
using System.Management; // Ensure this is included

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
            long availableRam = (long)ramInfo.AvailablePhysicalMemory;
            long usedRam = totalRam - availableRam;

            // Calculate used RAM in GB and percentage
            double usedRamInGB = usedRam / (1024.0 * 1024 * 1024);
            double totalRamInGB = totalRam / (1024.0 * 1024 * 1024);
            double usedRamPercentage = (usedRamInGB / totalRamInGB) * 100;
            float ava = (int)(availableRam / (1024 * 1024));

            // Display RAM information
            tram.Text = string.Empty;
            tram.Text = $"\nTotal RAM: {totalRamInGB:F2} GB\n" +
                       $"\nUsed RAM: {usedRamInGB:F2} GB ({usedRamPercentage:F2}%)\n" +
                       $"\nAvailable RAM: {ava / 1024} GB\n";

            // Get detailed RAM slot information
            GetRamSlotInfo();
        }

        private void GetRamSlotInfo()
        {
            // Use WMI to get RAM slot information
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

            // Initialize a string to hold all RAM slot information
            string allRamInfo = string.Empty;

            foreach (ManagementObject ram in searcher.Get())
            {
                string capacity = ram["Capacity"] != null ? $"{Convert.ToInt64(ram["Capacity"]) / (1024 * 1024 * 1024)} GB" : "N/A";
                string type = ram["MemoryType"] != null ? ram["MemoryType"].ToString() : "N/A"; // MemoryType is an integer, you may need to map it to a string
                string manufacturer = ram["Manufacturer"]?.ToString() ?? "N/A";
                string partNumber = ram["PartNumber"]?.ToString() ?? "N/A";
                string speed = ram["Speed"]?.ToString() ?? "N/A";
                string serialNumber = ram["SerialNumber"]?.ToString() ?? "N/A";
                string voltage = ram["ConfiguredVoltage"] != null ? $"{ram["ConfiguredVoltage"]} V" : "N/A"; // Assuming ConfiguredVoltage is available
                string slotType = ram["FormFactor"] != null ? ram["FormFactor"].ToString() : "N/A"; // FormFactor is an integer, you may need to map it to a string

                // Append the information for this RAM slot to the allRamInfo string
                allRamInfo += $"# RAM Slot Info {serialNumber} :\n\n" +
                               $"- Capacity: {capacity}\n" +
                               $"- Type: {type}\n" +
                               $"- Manufacturer: {manufacturer}\n" +
                               $"- Part Number: {partNumber}\n" +
                               $"- Speed: {speed} MHz\n" +
                               $"- Serial Number: {serialNumber}\n" +
                               $"- Voltage: {voltage}\n" +
                               $"- Slot Type: {slotType}\n\n"; // Add a newline for separation between slots
            }

            // Display all RAM slot information in the label
            raminfors1.Text = allRamInfo;
        }
    }
}