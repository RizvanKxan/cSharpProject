using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rabotator_ver_2_1_css
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        // закрываем форму
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // при загрузке формы и при наведении на картинки всплывает подсказка
      
        
        private void Form3_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox1, "Выход.");

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
                }
                
                var test = new AutoCompleteStringCollection();

                listBox1.DataSource = listA;
                listBox2.DataSource = listB;
                listBox3.DataSource = listC;
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

        
        // перетаскивание формы по левому щелчку мыши
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
 
    }
}
