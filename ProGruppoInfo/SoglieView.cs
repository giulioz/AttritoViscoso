using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProGruppoInfo
{
    public partial class SoglieView : Form
    {
        public bool noClose = true;
        public SoglieView()
        {
            InitializeComponent();
        }

        private void SoglieView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = noClose;
        }
    }
}
