using System;
using System.Windows.Forms;

namespace Rabotator_ver_2_1_css
{
    public partial class PageSetup : Form
    {
        public PageSetup()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "A4";
        }

        private void PageSetup_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                Data.orientationPageIsPortrait = true;
            }
            else
            {
                Data.orientationPageIsPortrait = false;
            }
            if(comboBox1.Text == "A4")
            {
                Data.sizePage = new System.Drawing.Printing.PaperSize ("A4",595,842);

            }
            else
            {
                Data.sizePage = new System.Drawing.Printing.PaperSize("Zebra", 6, 10);
            }

            Close();
        }

    }
}
