﻿using System;
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
    public partial class BSEDarchieve : Form
    {
        public BSEDarchieve()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSEDPcc BSEDcompiler = new BSEDPcc();
            BSEDcompiler.Show();
            this.Close();
        }
    }
}
