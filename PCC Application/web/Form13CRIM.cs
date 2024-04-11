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
    public partial class BSCRIMcompiler : Form
    {
        public BSCRIMcompiler()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSCRIMarchieve form18 = new BSCRIMarchieve();
            form18.Show();
            this.Close();
        }
    }
}
