using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Rabotator_ver_2_1_css
{
    public partial class Volume : Form
    {

        public Volume()
        {
            InitializeComponent();

        }
        // считаем объём если входные данные сантиметры 
        private void Volume_San(decimal a, decimal b, decimal c, decimal d)
        {
            decimal V, V2;
            V = (a * 10) * (b * 10) * ((c * 10) / d) / 1000000000;
            textBox5.Text = V.ToString();
            V2 = (a * 10) * (b * 10) * ((c * 10) / d);
            textBox6.Text = V2.ToString();
        }
        // считаем объём если входные данные миллиметры 
        private void Volume_Mili(decimal a, decimal b, decimal c, decimal d)
        {
            decimal V, V2;
            V = a * b * (c / d) / 1000000000;
            textBox5.Text = V.ToString();
            V2 = a * b * (c / d);
            textBox6.Text = V2.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(textBox1.Text, out decimal a))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox2.Text, out decimal b))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox3.Text, out decimal c))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox4.Text, out decimal d))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
                textBox4.Text = "1";
                d = 1;
            }


            if (radioButton1.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_San(a, b, c, d);

                }
               

            }
            if (radioButton2.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_Mili(a, b, c, d);
                }
                

            }
        }


        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(textBox1.Text, out decimal a))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox2.Text, out decimal b))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox3.Text, out decimal c))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox4.Text, out decimal d))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
                textBox4.Text = "1";
                d = 1;
            }

            if (radioButton1.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_San(a, b, c, d);
                }
                    
            }
            if (radioButton2.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_Mili(a, b, c, d);
                }
                    
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(textBox1.Text, out decimal a))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox2.Text, out decimal b))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox3.Text, out decimal c))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox4.Text, out decimal d))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
                textBox4.Text = "1";
                d = 1;
            }

            if (radioButton1.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_San(a, b, c, d);
                }
                    
            }
            if (radioButton2.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_Mili(a, b, c, d);
                }
                    
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(textBox1.Text, out decimal a))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox2.Text, out decimal b))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox3.Text, out decimal c))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox4.Text, out decimal d))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
                textBox4.Text = "1";
                d = 1;
            }

            if (radioButton1.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_San(a, b, c, d);
                }
                   
            }
            if (radioButton2.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_Mili(a, b, c, d);
                }
                    
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(textBox1.Text, out decimal a))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox2.Text, out decimal b))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox3.Text, out decimal c))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox4.Text, out decimal d))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
                textBox4.Text = "1";
                d = 1;
            }

            if (radioButton1.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_San(a, b, c, d);
                }
                    
            }
            if (radioButton2.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_Mili(a, b, c, d);
                }
                    
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!Decimal.TryParse(textBox1.Text, out decimal a))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox2.Text, out decimal b))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox3.Text, out decimal c))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
            }
            if (!Decimal.TryParse(textBox4.Text, out decimal d))
            {
                MessageBox.Show("Некорректное число. Используйте только цифры и запятую!", "Будьте бдительны!");
                textBox4.Text = "1";
                d = 1;
            }

            if (radioButton1.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_San(a, b, c, d);
                }
                   
            }
            if (radioButton2.Checked == true)
            {
                if (d == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!", "Будьте бдительны!");
                    textBox4.Text = "1";
                }
                else
                {
                    Volume_Mili(a, b, c, d);
                }
                   
            }
        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();

        }

        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();
        }

        private void TextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.SelectAll();
        }

        private void TextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.SelectAll();
        }


        public class Data
        {
            public string Column1 { get; set; }

            public string Column2 { get; set; }

            public string Column3 { get; set; }

            public static Data FromCSV(string CSVLine)
            {
                string[] Values = CSVLine.Split(';');

                Data DailyValues = new Data();

                DailyValues.Column1 = Values[0];

                DailyValues.Column2 = Values[1];

                DailyValues.Column3 = Values[2];

                return DailyValues;
            }
        }
        // закрываем приложение
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // при загрузке формы и при наведении на картинки всплывает подсказка
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox1, "Выход.");
        }
        // перетаскивание формы по левому щелчку мыши
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Users newForm = new Users();
            newForm.Show();
        }




        //////////






        /////
    }
}

