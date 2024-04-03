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
    public partial class BSBAPcc : Form
    {
        public BSBAPcc()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BSBAarchieve bSBAarchieve = new BSBAarchieve();
            bSBAarchieve.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            BSBAcompiler bSBAcompiler = new BSBAcompiler();
            bSBAcompiler.ShowDialog();
        }
    }
}
