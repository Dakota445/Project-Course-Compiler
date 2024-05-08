using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Course_Compiler
{
    public partial class Show_URL_Form : Form
    {
        public Show_URL_Form(string Stored_Url)
        {
            InitializeComponent();
            textBox1.Text = Stored_Url;
        }
    }
}
