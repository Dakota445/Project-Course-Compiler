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
            BSITPcc BSITPcc = new BSITPcc();
            BSITPcc.Show();
            this.Close();
        }
    }
}
