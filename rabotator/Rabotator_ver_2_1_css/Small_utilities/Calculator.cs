using Rabotator.Properties;
using System;
using System.Windows.Forms;

namespace Rabotator.Small_utilities
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Show();
            panel9.MouseMove += (s, a) =>
            {
                panel9.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
                label9.ForeColor = System.Drawing.Color.FromArgb(12, 135, 50);
            };
            panel9.MouseLeave += (s, a) =>
            {
                panel9.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
                label9.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            };
            label9.MouseMove += (s, a) =>
            {
                panel9.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
                label9.ForeColor = System.Drawing.Color.FromArgb(12, 135, 50);
            };
            label9.MouseLeave += (s, a) =>
            {
                panel9.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
                label9.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            };
        }

        private void Calculator_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Close();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources.exit_closethesession_close_6317;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Dark_exit_closethesession_close_6317;
        }

        private void Panel13_MouseMove(object sender, MouseEventArgs e)
        {
            panel13.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
            label13.ForeColor = System.Drawing.Color.FromArgb(12, 135, 50);
        }

        private void Panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
            label13.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
        }

        private void Label13_MouseMove(object sender, MouseEventArgs e)
        {
            label13.ForeColor = System.Drawing.Color.FromArgb(12, 135, 50);
            panel13.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
        }
        
        private void Label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            panel13.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }
    }
}
