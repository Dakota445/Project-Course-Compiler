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
    public partial class BSITcompiler : Form
    {
        public BSITcompiler()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSITPcc form6it = new BSITPcc();
            form6it.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSITPcc form6it = new BSITPcc();
            form6it.Show();
            this.Close();

        }

        private void BSITcompiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
