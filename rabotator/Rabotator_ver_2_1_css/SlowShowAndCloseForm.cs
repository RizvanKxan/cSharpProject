using System;
using System.Windows.Forms;

namespace Rabotator
{
    class SlowShowAndCloseForm
    {
        private readonly Form form;
        public SlowShowAndCloseForm(Form form)
        {
            this.form = form;
        }

        readonly Timer tmrShow = new Timer();
        readonly Timer tmrClose = new Timer(); 
        private double opacity = 0;
        private double opacity2 = 1; 

        public void Show()
        { 
            form.Opacity = opacity;
            tmrShow.Interval = 1;
            tmrShow.Tick += new EventHandler(TmrShow_Tick); 
            tmrShow.Enabled = true; 
        }

        public void Close()
        { 
            form.Opacity = opacity2;
            tmrClose.Interval = 1;
            tmrClose.Tick += new EventHandler(TmrClose_Tick); 
            tmrClose.Enabled = true; 
        }

        private void TmrShow_Tick(object sender, EventArgs e) 
        {
            opacity += 0.02;  
            form.Opacity = opacity; 
            if (form.Opacity >= 1) tmrShow.Stop();
        }
        private void TmrClose_Tick(object sender, EventArgs e)
        {
            opacity2 -= 0.02;
            form.Opacity = opacity2;
            if (form.Opacity <= 0)
            {
                tmrClose.Stop();
                form.Close();
            }
        }
    }
}
