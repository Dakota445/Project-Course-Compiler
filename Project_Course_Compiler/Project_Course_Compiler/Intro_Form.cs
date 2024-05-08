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
    public partial class Intro_Form : Form
    {
        public Intro_Form()
        {
            InitializeComponent();
        }

        private void IT_btn_Click(object sender, EventArgs e)
        {
            IT_area.IT_Login login = new IT_area.IT_Login();
            login.Show();
            this.Hide();
        }

        private void Intro_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
