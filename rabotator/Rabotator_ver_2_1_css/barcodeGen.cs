using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rabotator
{
    public partial class BarcodeGeneration : Form
    {       
        public BarcodeGeneration()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "A4";
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                pageSetupDialog1.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Принтер не установлен.","ERROR!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = Data.sizePage;
            if(Data.orientationPageIsPortrait == true)
            {
                printDocument1.DefaultPageSettings.Landscape = false;
            }
            else
            {
                printDocument1.DefaultPageSettings.Landscape = true;
            }
            // окно предпросмотра теряет фокус и порой скрывается после появления, разобраться почему
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Принтер не установлен.", "ERROR!");
            }
            
            
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);

            if(Data.sizePage.Width == 595)
            {
                e.Graphics.DrawImage(bmp, 100,100);
                e.Graphics.DrawString(textBox1.Text,
                                      new Font("Arial", 8),
                                      Brushes.Black, 105, 153);
                // придумать как выровнять текст-подпись по центру изображения
            }
            else
            {
                e.Graphics.DrawImage(bmp,1,1,8,4);
                e.Graphics.DrawString(textBox1.Text,
                                      new Font("Arial", 0.5f),
                                      Brushes.Black,
                                      e.PageBounds.Width / 2 - e.Graphics.MeasureString(textBox1.Text, new Font("Arial", 0.5f)).Width / 2,
                                      4.9f);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Close();
        }

        private void BarcodeGeneration_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void TxtBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string barcode = textBox1.Text;
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = brCode.Draw(barcode, 50);
                pictureBox1.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ввод не корректен!", "Будьте бдительны!");
            }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "A4")
            {
                Data.sizePage = new System.Drawing.Printing.PaperSize("A4", 595, 842);
                Data.orientationPageIsPortrait = true;
            }
            else
            {
                Data.sizePage = new System.Drawing.Printing.PaperSize("Zebra", 6, 10);
                Data.orientationPageIsPortrait = false;
            }
        }
    }
}
