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
    public partial class BSITProjectcompiler : Form
    {
        public BSITProjectcompiler()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSITCompiler form6it = new BSITCompiler();
            form6it.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSITCompiler bSITCompiler = new BSITCompiler();
            bSITCompiler.Show();
            this.Hide();
        }

        private void BSITcompiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
