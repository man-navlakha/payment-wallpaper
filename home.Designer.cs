namespace WallpaperChanger
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wall = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(93, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wall
            // 
            this.wall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wall.Location = new System.Drawing.Point(182, 248);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(137, 23);
            this.wall.TabIndex = 3;
            this.wall.Text = "Test Payment";
            this.wall.UseVisualStyleBackColor = true;
            this.wall.Click += new System.EventHandler(this.wall_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.aboutus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 48);
            this.panel1.TabIndex = 4;
            // 
            // aboutus
            // 
            this.aboutus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutus.AutoSize = true;
            this.aboutus.Location = new System.Drawing.Point(449, 18);
            this.aboutus.Name = "aboutus";
            this.aboutus.Size = new System.Drawing.Size(35, 13);
            this.aboutus.TabIndex = 5;
            this.aboutus.Text = "About";
            this.aboutus.Click += new System.EventHandler(this.aboutus_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "home";
            this.Text = "Brand Dilation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button wall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aboutus;
    }
}