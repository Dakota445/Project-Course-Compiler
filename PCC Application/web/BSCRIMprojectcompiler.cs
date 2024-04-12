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
            BSCRIMPcc BSCRIMcompiler = new BSCRIMPcc();
            BSCRIMcompiler.Show();
            this.Close();
        }
    }
}
