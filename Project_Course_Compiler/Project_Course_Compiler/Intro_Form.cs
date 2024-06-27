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

        private void CRIM_btn_Click(object sender, EventArgs e)
        {
            CRIM_area.CRIM_Login login = new CRIM_area.CRIM_Login();
            login.Show();
            this.Hide();
        }

        private void TEP_btn_Click(object sender, EventArgs e)
        {
            TEP_area.TEP_Login login = new TEP_area.TEP_Login();
            login.Show();
            this.Hide();
        }

        private void HM_btn_Click(object sender, EventArgs e)
        {
            HM_area.HM_Login login = new HM_area.HM_Login();
            login.Show();
            this.Hide();
        }

        private void BSBA_btn_Click(object sender, EventArgs e)
        {
            BSBA_area.BSBA_Login login = new BSBA_area.BSBA_Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
