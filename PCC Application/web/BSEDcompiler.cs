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
    public partial class BSEDPcc : Form
    {
        public BSEDPcc()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            BSEDarchieve BSEDprojectarchive = new BSEDarchieve();
            BSEDprojectarchive.Show();
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            BSEDcompiler bSEDcompiler = new BSEDcompiler();
            bSEDcompiler.Show();
            this.Close ();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form10ED_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSEDlogin form1 = new BSEDlogin();
            form1.Show();
            this.Close(); 
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
