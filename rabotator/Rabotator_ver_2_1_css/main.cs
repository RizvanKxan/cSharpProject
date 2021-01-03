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
            t.SetToolTip(picExit, "Выход.");
            t.SetToolTip(picVolume, "Объёмы Юск.");
            t.SetToolTip(picUsers, "Пользователи.");
            t.SetToolTip(picSkaner, "Смена номера MDT.");
            t.SetToolTip(picBookmark, "Хранение.");
            t.SetToolTip(picBarcode, "Генерация штрих-кода.");

        }


        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Pair newForm = new Pair();
            newForm.Show();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            picVolume.Image = Resources._32officeicons_31_89708;
            timer1.Stop();
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            picVolume.Image = Resources.Dark_32officeicons_31_89708;
            timer1.Start();
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            picUsers.Image = Resources.robot_eset_57x64;
            timer1.Stop();
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            picUsers.Image = Resources.Dark_robot_eset_57x64;
            timer1.Start();
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            picExit.Image = Resources.exit_closethesession_close_6317;
            timer1.Stop();
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Resources.Dark_exit_closethesession_close_6317;
            timer1.Start();
        }


        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MDT newForm = new MDT();
            newForm.Show();
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            picSkaner.Image = Resources.Dark_icons8_сканер_штрих_кодов_2_100;
            timer1.Start();
        }

        private void PictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            picSkaner.Image = Resources.icons8_сканер_штрих_кодов_2_100;
            timer1.Stop();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Bookmarks newForm = new Bookmarks();
            newForm.Show();
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            picBookmark.Image = Resources.Dark_taskbar_list_tarea_9370;
            timer1.Start();
        }

        private void PictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            picBookmark.Image = Resources.taskbar_list_tarea_9370;
            timer1.Stop();
        }


        private void PictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
            timer1.Stop();
        }


        private void PictureBox7_MouseEnter(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(panel6.Visible == false)
            {
                timer1.Enabled = false;
            }
            else
            {
                panel6.Visible = false;
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

        private void PictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            picBarcode.Image = Resources.barcoderegular_106329;
            timer1.Stop();
        }

        private void PictureBox8_MouseLeave(object sender, EventArgs e)
        {
            picBarcode.Image = Resources.Dark_barcoderegular_106329;
            timer1.Start();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if(panel6.Visible == true)
            {
                panel6.Visible = false;
            }
            else
            {
                panel6.Visible = true;
            }
        }
    }
}
