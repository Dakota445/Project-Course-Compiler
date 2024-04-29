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
    public partial class ProjectCC : Form
    {
        public ProjectCC()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSCRIMlogin crim = new BSCRIMlogin();
            crim.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSEDlogin ed = new BSEDlogin();
            ed.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {   
            HMlogin hm = new HMlogin();
            hm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BSITlogin it = new BSITlogin();
            it.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BSBAlogin ba = new BSBAlogin();
            ba.Show();
            this.Hide();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
