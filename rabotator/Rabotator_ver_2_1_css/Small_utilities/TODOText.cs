using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rabotator.Small_utilities
{
    public partial class TODOText : Form
    {
        public TODOText()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Data.TODOstring = textBox1.Text;
            TODOList newForm = new TODOList();
            newForm.Show();
            SlowShowAndCloseForm ss = new SlowShowAndCloseForm(this);
            ss.Close();
        }
    }
}
