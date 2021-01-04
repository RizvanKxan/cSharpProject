using Rabotator_ver_2_1_css.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Rabotator_ver_2_1_css
{
    public partial class Bookmarks : Form
    {
        public Bookmarks()
        {
            InitializeComponent();
            
        }

        private void Bookmarks_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public class BookmarksList
        {
            public string Name { get; set; }
            public string Link { get; set; }
            public string Description { get; set; }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://vk.com");
        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Panel4_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Panel5_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Panel6_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Panel7_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

        private void Panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
        }

        private void Panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
        }

        private void Panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
        }

        private void Panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
        }

        private void Panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
        }

        private void Panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

        private void Panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

        private void Panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

        private void Panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

        private void Panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }
    }
}

