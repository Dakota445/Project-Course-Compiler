using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web
{
    public partial class BSHMPcc : Form
    {
        public BSHMPcc()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BSHMarchieve bSHMarchieve = new BSHMarchieve();
            bSHMarchieve.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            BSHMcompiler bSHMcompiler = new BSHMcompiler();
            bSHMcompiler.Show();

        }
    }
}
