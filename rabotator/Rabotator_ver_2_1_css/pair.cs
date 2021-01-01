using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Rabotator_ver_2_1_css
{
    public partial class Pair : Form
    {
        public Pair()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pair_Load(object sender, EventArgs e)
        {

            using (var reader = new StreamReader(@"Учётки.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                List<string> listC = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0] + " " + values[2] + " " + values[1]); // логин - фамилия - имя
                    listB.Add(values[2] + " " + values[1] + " " + values[0]); // фамилия - имя - логин
                    listC.Add(values[1] + " " + values[2] + " " + values[0]); // имя - фамилия - логин

                    dataGridView1.Rows.Add(values[0], values[2], values[1]);
                }

                var test = new AutoCompleteStringCollection();

               // listBox1.DataSource = listA;
               // listBox2.DataSource = listB;
               // listBox3.DataSource = listC;
                List<string> listX = new List<string>();
                listX.AddRange(listA);
                listX.AddRange(listB);
                listX.AddRange(listC);

                var teswwt = new AutoCompleteStringCollection();
                teswwt.AddRange(listX.ToArray());
                 textBox1.AutoCompleteCustomSource = teswwt;
                 textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                 textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

                
            }


        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
