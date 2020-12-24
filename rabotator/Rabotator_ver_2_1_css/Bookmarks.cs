using Rabotator_ver_2_1_css.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Rabotator_ver_2_1_css
{
    public partial class Bookmarks : Form
    {
        public Bookmarks()
        {
            InitializeComponent();
            
        }

        private void Bookmarks_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public class BookmarksList
        {
            public string Link { get; set; }
            public string Description { get; set; }

            //public string str = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // указываем путь к файлу csv
            string pathCsvFile = @"Bookmarks.csv";
      
            StreamWriter writer = new StreamWriter(pathCsvFile, true);
            writer.WriteLine(textBox1.Text + ";" + textBox2.Text);
            writer.Close();
           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
           // Resources.Bookmarks.Save();

            using (var reader = new StreamReader(@"Bookmarks.csv"))
            {
                List<string> listA = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0] + " " + values[1]);
                    dataGridView1.Rows.Add(values[0], values[1]);
                }

            }



        }

        private void Bookmarks_Load(object sender, EventArgs e)
        {
            File.WriteAllText(@"Bookmarks.csv", Resources.Bookmarks);
        }
    }
}

