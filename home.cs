using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperChanger
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void wall_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }



        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void screenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test test = new test();
            test.Show();
        }

        private void btn_Screen_Click(object sender, EventArgs e)
        {
            test test = new test();
            test.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open the RAM Test form when button1 is clicked
            OpenForm(new ram_I());
        }

        //Button windowsInfoButton = new Button { Text = "Windows Information", Dock = DockStyle.Top };
        //windowsInfoButton.Click += (s, e) => OpenForm(new WindowsInfoForm());


        private void OpenForm(Form form)
        {
            // Clear existing controls and show the new form
            dj.Controls.Clear();
            form.TopLevel = false;
            dj.Controls.Add(form);
            form.Show();
        }
    }
}
