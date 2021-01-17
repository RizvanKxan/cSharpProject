using System;
using System.Windows.Forms;
using Rabotator.Small_utilities;

namespace Rabotator
{
    public partial class Utilities : Form
    {
        public Utilities()
        {
            InitializeComponent();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Show();

        }

        private void Bookmarks_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Close();
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = System.Drawing.Color.FromArgb(12, 135, 50);
            l.BackColor = System.Drawing.Color.FromArgb(10, 6, 49);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
            l.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Calculator newForm = new Calculator();
            newForm.Show();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Close();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void Panel4_MouseClick(object sender, MouseEventArgs e)
        {
            TODOListMain newForm = new TODOListMain();
            newForm.Show();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Close();

        }

        private void Panel5_MouseClick(object sender, MouseEventArgs e)
        {
            EnglishExpressions newForm = new EnglishExpressions();
            newForm.Show();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Close();

        }

        private void Panel6_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void Panel7_MouseClick(object sender, MouseEventArgs e)
        {


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

