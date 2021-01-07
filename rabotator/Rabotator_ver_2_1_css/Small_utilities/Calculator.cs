using Rabotator.Properties;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Rabotator.Small_utilities
{
    
    public partial class Calculator : Form
    {
        private decimal Number1 { get; set; }
        private decimal Number2 { get; set; }
        private decimal Result { get; set; }

        public Calculator()
        {
            InitializeComponent();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Show();
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if((l.Text == ".") || (l.Text == ","))
            {
                if ((textBox1.Text.Contains(",")) || ((textBox1.Text.Contains(".")))) { }
                else { textBox1.AppendText(l.Text); }
            }
            else if((l.Text == "/") || 
                    (l.Text == "*") || 
                    (l.Text == "-") || 
                    (l.Text == "+"))
                 {
                    if(textBox1.Text.Length > 0)
                    {
                        if ((textBox1.Text[textBox1.Text.Length - 1] == '/') ||
                        (textBox1.Text[textBox1.Text.Length - 1] == '*') ||
                        (textBox1.Text[textBox1.Text.Length - 1] == '-') ||
                        (textBox1.Text[textBox1.Text.Length - 1] == '+'))
                        {

                        }
                        else
                        {
                        textBox1.AppendText(l.Text);
                        }
                    }
                
                 }
            else { textBox1.AppendText(l.Text); }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            Thread myThread = new Thread(new ParameterizedThreadStart(SimulationOfPressing));
            switch (e.KeyValue)
            {
                case (char)Keys.NumPad0:
                    Label_Click(valueLabel0, null);
                    myThread.Start(valueLabel0);
                    break;
                case (char)Keys.NumPad1:
                    Label_Click(valueLabel1, null);
                    myThread.Start(valueLabel1);
                    break;
                case (char)Keys.NumPad2:
                    Label_Click(valueLabel2, null);
                    myThread.Start(valueLabel2);
                    break;
                case (char)Keys.NumPad3:
                    Label_Click(valueLabel3, null);
                    myThread.Start(valueLabel3);
                    break;
                case (char)Keys.NumPad4:
                    Label_Click(valueLabel4, null);
                    myThread.Start(valueLabel4);
                    break;
                case (char)Keys.NumPad5:
                    Label_Click(valueLabel5, null);
                    myThread.Start(valueLabel5);
                    break;
                case (char)Keys.NumPad6:
                    Label_Click(valueLabel6, null);
                    myThread.Start(valueLabel6);
                    break;
                case (char)Keys.NumPad7:
                    Label_Click(valueLabel7, null);
                    myThread.Start(valueLabel7);
                    break;
                case (char)Keys.NumPad8:
                    Label_Click(valueLabel8, null);
                    myThread.Start(valueLabel8);
                    break;
                case (char)Keys.NumPad9:
                    Label_Click(valueLabel9, null);
                    myThread.Start(valueLabel9);
                    break;
                case (char)Keys.Delete:
                    textBox1.Text = "";
                    myThread.Start(valueLabelDel);
                    break;
                case (char)Keys.Divide:
                    Label_Click(valueLabelSlash, null);
                    myThread.Start(valueLabelSlash);
                    break;
                case (char)Keys.OemMinus:
                    Label_Click(valueLabelMinus, null);
                    myThread.Start(valueLabelMinus);
                    break;
                case (char)Keys.Subtract:
                    Label_Click(valueLabelMinus, null);
                    myThread.Start(valueLabelMinus);
                    break;
                case (char)Keys.Add:
                    Label_Click(valueLabelPlus, null);
                    myThread.Start(valueLabelPlus);
                    break;
                case (char)Keys.Oemplus:
                    Label_Click(valueLabelPlus, null);
                    myThread.Start(valueLabelPlus);
                    break;
                case (char)Keys.OemPeriod:
                    Label_Click(valueLabelDot, null);
                    myThread.Start(valueLabelDot);
                    break;
                case (char)Keys.Decimal:
                    Label_Click(valueLabelDot, null);
                    myThread.Start(valueLabelDot);
                    break;
                case (char)Keys.Multiply:
                    Label_Click(valueLabelStar, null);
                    myThread.Start(valueLabelStar);
                    break;
                case (char)Keys.Back:
                    if(textBox1.Text.Length > 0)
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.ScrollToCaret();
                        textBox1.Refresh();
                    }
                    break;
            }
        }

        public void SimulationOfPressing(object obj)
        {
            Label l = (Label)obj;
            Label_MouseMove(l, null);
            Thread.Sleep(200);
            Label_MouseLeave(l, null);
        }

        private void ValueLabelDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
