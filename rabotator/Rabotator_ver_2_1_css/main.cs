using Rabotator_ver_2_1_css.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rabotator_ver_2_1_css
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Volume newForm = new Volume();
            newForm.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - 2 * Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - Screen.PrimaryScreen.WorkingArea.Height;
            Location = new Point(x, y);
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2, "Выход.");
            t.SetToolTip(pictureBox1, "Объёмы Юск.");
            t.SetToolTip(pictureBox3, "Пользователи.");
            t.SetToolTip(pictureBox4, "Смена номера MDT.");

        }


        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Pair newForm = new Pair();
            newForm.Show();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Resources._32officeicons_31_89708;
            pictureBox1.Width = 77;
            pictureBox1.Height = 77;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Dark_32officeicons_31_89708;
            pictureBox1.Width = 77;
            pictureBox1.Height = 77;
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Resources.robot_eset_57x64;
            pictureBox3.Width = 77;
            pictureBox3.Height = 77;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.Dark_robot_eset_57x64;
            pictureBox3.Width = 77;
            pictureBox3.Height = 77;
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Resources.exit_closethesession_close_6317;
            pictureBox2.Width = 77;
            pictureBox2.Height = 77;
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.Dark_exit_closethesession_close_6317;
            pictureBox2.Width = 77;
            pictureBox2.Height = 77;
        }


        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MDT newForm = new MDT();
            newForm.Show();
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.Dark_icons8_сканер_штрих_кодов_2_100;
            
            pictureBox4.Width = 77;
            pictureBox4.Height = 77;
        }

        private void PictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Resources.icons8_сканер_штрих_кодов_2_100;
            pictureBox4.Width = 77;
            pictureBox4.Height = 77;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Bookmarks newForm = new Bookmarks();
            newForm.Show();
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.Dark_taskbar_list_tarea_9370;
            
            pictureBox5.Width = 77;
            pictureBox5.Height = 77;
        }

        private void PictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Resources.taskbar_list_tarea_9370;
            pictureBox5.Width = 77;
            pictureBox5.Height = 77;
        }


        private void PictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            
            pictureBox7.Capture = false;

            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }


        private void PictureBox7_MouseEnter(object sender, EventArgs e)
        {
            
            if (panel6.Height == 485)
            {
                panel6.Height = 0;
            }
            else
            {
                panel6.Height = 485;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (panel6.Height == 485)
            {
                panel6.Height = 0;
            }
        }

        private void PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            BarcodeGeneration newForm = new BarcodeGeneration();
            newForm.Show();
        }
    }
}
