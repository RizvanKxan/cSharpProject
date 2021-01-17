using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Rabotator.Small_utilities
{
    public partial class EnglishExpressions : Form
    {
        public const string pathData = @"Data.txt";
        public List<string> dataString = new List<string>();
        public EnglishExpressions()
        {
            InitializeComponent();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Show();
            Location = new Point(0, 0);
            Width = (int)System.Windows.SystemParameters.PrimaryScreenWidth;

            if(File.Exists(pathData))
            {
                using (var reader = new StreamReader(pathData))
                {
                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        dataString.Add(line);
                    }
                }
            }
            tmr1.Start();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(label1,"Левая кнопка мыши - пауза. Правая - закрытие формы.");

        }

        private void EnglishExpressions_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void Tmr1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = dataString[rnd.Next(0,dataString.Count)];
        }
        private Point MouseHook;
        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            //только вертикальное перемещение формы
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point(Location.X, Location.Y - MouseHook.Y + e.Location.Y);
        }

        private void Label1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(tmr1.Enabled)
                {
                    tmr1.Stop();
                }
                else
                {
                    tmr1.Start();
                }
            }
            if(e.Button == MouseButtons.Right)
            {
                Close();
            }
        }
    }
}
