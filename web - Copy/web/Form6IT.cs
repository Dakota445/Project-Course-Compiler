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
    public partial class BSITPcc : Form
    {
        public BSITPcc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            BSITcompiler bSITcompiler = new BSITcompiler(); 
            bSITcompiler.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BSITarchieve bSITarchieve  = new BSITarchieve();
            bSITarchieve.Show();
        }
    }
}
