using System;
using System.Windows.Forms;
using System.Xml;

namespace Rabotator_ver_2_1_css
{
    public partial class MDT : Form
    {
        public MDT()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox1.Text.Length < 6))
            {
                MessageBox.Show("Не допустимая длина или текстовое поле пусто.", "Ошибка.");
            }
            else
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"settings.xml");
                // получим корневой элемент
                XmlElement xRoot = xDoc.DocumentElement;
                // обход всех узлов в корневом элементе
                foreach (XmlNode xnode in xRoot)
                {
                    // обходим все дочерние узлы элемента user
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // если узел - Link - меняем текст на текст из текстбокса
                        if (childnode.Name == "Link")
                        {
                            childnode.InnerText = textBox1.Text;
                            MessageBox.Show("Информация успешно обновлена. Можно запускать терминал.", "Успех.");
                        }
                        /* если узел age
                        if (childnode.Link == "Task")
                        {
                            Console.WriteLine($"Task: {childnode.InnerText}");
                        } */
                    }
                    xDoc.Save(@"settings.xml");
                }
            }
            
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((textBox1.Text == "") || (textBox1.Text.Length < 6))
                {
                    MessageBox.Show("Не допустимая длина или текстовое поле пусто.", "Ошибка.");
                }
                else
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(@"settings.xml");
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                    // обход всех узлов в корневом элементе
                    foreach (XmlNode xnode in xRoot)
                    {
                        // обходим все дочерние узлы элемента user
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            // если узел - Link - меняем текст на текст из текстбокса
                            if (childnode.Name == "Link")
                            {
                                childnode.InnerText = textBox1.Text;
                                MessageBox.Show("Информация успешно обновлена. Можно запускать терминал.", "Успех.");
                            }
                            /* если узел age
                            if (childnode.Link == "Task")
                            {
                                Console.WriteLine($"Task: {childnode.InnerText}");
                            } */
                        }
                        xDoc.Save(@"settings.xml");
                    }
                }
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2, "Внести изменения.");
            t.SetToolTip(pictureBox1, "Выход.");
            t.SetToolTip(textBox1, "Поле для ввода номера терминала. Пример: MDT666.");
        }
    }
}
