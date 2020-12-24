using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rabotator_ver_2_1_css
{
    public partial class Main : Form
    {
        public Main()
        {
            
            InitializeComponent();
            
        }
        // закрываем форму
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Volume newForm = new Volume();
            newForm.Show();
            
        }
        //перетаскивание формы
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2, "Выход.");
            t.SetToolTip(pictureBox1, "Объёмы Юск.");
            t.SetToolTip(pictureBox3, "Пользователи.");
            t.SetToolTip(pictureBox4, "Смена номера MDT.");

        }

        /*private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            if (label1.ForeColor == Color.Black)
            {
                label1.ForeColor = Color.White;
            }
            else
            {
                label1.ForeColor = Color.Black;
            }
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else
            {
                panel1.Visible = true; 
                panel2.Visible = true; 
                panel3.Visible = true; 
                panel4.Visible = true; 
            }
        }*/

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Pair newForm = new Pair();
            newForm.Show();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Width = 65;
            pictureBox1.Height = 65;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Width = 48;
            pictureBox1.Height = 48;
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Width = 65;
            pictureBox3.Height = 65;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Width = 48;
            pictureBox3.Height = 48;
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Width = 65;
            pictureBox2.Height = 65;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Width = 48;
            pictureBox2.Height = 48;
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MDT newForm = new MDT();
            newForm.Show();
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Width = 48;
            pictureBox4.Height = 48;
        }

        private void PictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Width = 65;
            pictureBox4.Height = 65;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Bookmarks newForm = new Bookmarks();
            newForm.Show();
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Width = 48;
            pictureBox5.Height = 48;
        }

        private void PictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Width = 65;
            pictureBox5.Height = 65;
        }
    }
}
