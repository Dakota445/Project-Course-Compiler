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

        private void button4_Click(object sender, EventArgs e)
        {
            BSBAlogin form7 = new BSBAlogin();
            form7.Show();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            BSBAarchieve BSBAprojectarchive = new BSBAarchieve();
            BSBAprojectarchive.Show();
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            BSBAcompiler BSBAprojectcompiler = new BSBAcompiler();
            BSBAprojectcompiler.Show();
            this.Close();
        }

        private void BSBAPcc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
