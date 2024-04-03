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
    public partial class BSEDlogin : Form
    {
        public BSEDlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BSEDPcc bSEDPcc = new BSEDPcc();    
            bSEDPcc.ShowDialog();
            this.Close();
        }
    }
}
