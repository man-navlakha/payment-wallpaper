﻿using System;
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


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
    }
}
