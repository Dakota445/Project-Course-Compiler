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
    public partial class HMlogin : Form
    {
        public HMlogin()
        {
            InitializeComponent();
        }

        private void Form11HM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BSHMPcc bSHMPcc = new BSHMPcc();
            bSHMPcc.Show();
            this.Close();
        }
    }
}
