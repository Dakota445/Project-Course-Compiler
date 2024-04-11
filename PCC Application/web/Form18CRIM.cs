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
    public partial class BSCRIMarchieve : Form
    {
        public BSCRIMarchieve()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSCRIMPcc bSCRIMPcc = new BSCRIMPcc();  
            bSCRIMPcc.Show();
            this.Close();
        }

        private void BSCRIMarchieve_Load(object sender, EventArgs e)
        {

        }
    }
}
