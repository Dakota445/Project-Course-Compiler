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
    public partial class BSITarchieve : Form
    {
        public BSITarchieve()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSITCompiler form6it = new BSITCompiler();
            form6it.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSITCompiler form6it = new BSITCompiler();
            form6it.Show();
            this.Close();
        }
    }
}
