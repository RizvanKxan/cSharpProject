using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rabotator_ver_2_1_css
{
    public partial class BarcodeGeneration : Form
    {       
        public BarcodeGeneration()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           // pageSetupDialog1.ShowDialog();
            PageSetup newForm = new PageSetup();
            newForm.Show();
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
            
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);

            Rectangle m = e.MarginBounds;
            
            if (bmp.Width / (double)bmp.Height > m.Width / (double)m.Height) // image is wider
            {
                m.Height = (int)(bmp.Height / (double)bmp.Width * m.Width);
            }
            else
            {
                m.Width = (int)(bmp.Width / (double)bmp.Height * m.Height);
            }

            if(Data.sizePage.Width == 595)
            {
                e.Graphics.DrawImage(bmp, m);
            }
            else
            {
                e.Graphics.DrawImage(bmp, e.PageBounds);
            }
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BarcodeGeneration_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
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
    }
}
