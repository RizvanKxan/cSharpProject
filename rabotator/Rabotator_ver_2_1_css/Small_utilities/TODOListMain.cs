using System;
using System.Windows.Forms;

namespace Rabotator.Small_utilities
{
    public partial class TODOListMain : Form
    {
        public TODOListMain()
        {
            InitializeComponent();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TODOText newForm = new TODOText();
            newForm.Show();
        }

        private void TODOListMain_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
