using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rabotator.Small_utilities
{
    public partial class TODOList : Form
    {
        public TODOList()
        {
            //https://youtu.be/duVN8iwDDo8
            //https://www.cyberforum.ru/csharp-net/thread164792.html
            //https://www.cyberforum.ru/windows-forms/thread1384351.html
            //https://youtu.be/QTWKUkiEqpQ

            InitializeComponent();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            for (int i = 0; i < 10; i++)
            {
                string fname = "Test" + i.ToString();
                TODOList tdL = (TODOList)Application.OpenForms[fname];

                if(tdL == null)
                {
                    this.Name = fname;
                    var x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                    var y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * (i+1);
                    this.Location = new Point(x, y);
                    break;
                }
            }
            label2.Text = Data.TODOstring;
            var X = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            ss.Show();
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.Text = "V";
            l.ForeColor = System.Drawing.Color.Chartreuse;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.Text = "X";
            l.ForeColor = System.Drawing.Color.Crimson;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Close();
        }
        private Point MouseHook;
        private void Label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point(Location.X, Location.Y - MouseHook.Y + e.Location.Y);
        }
    }
}
