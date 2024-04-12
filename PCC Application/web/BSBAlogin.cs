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
    public partial class BSBAlogin : Form
    {
        public BSBAlogin()
        {
            InitializeComponent();
        }

        private void Form7BA_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbuser.Text))
            {
                MessageBox.Show("Please fill out student id");
            }
            else if (string.IsNullOrEmpty(tbpassword.Text))
            {
                MessageBox.Show("Please fill out password");
            }
            else if (tbuser.Text.Contains("c220140") && tbpassword.Text.Contains("12760290063"))
            {

                MessageBox.Show("LOGIN SUCCESSFUL");
                tbuser.Clear();
                tbpassword.Clear();

                BSBAPcc bSBAPcc = new BSBAPcc();
                bSBAPcc.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD!!!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbuser.Clear();
                tbpassword.Clear();
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectCC form1 = new ProjectCC();
            form1.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbpassword.PasswordChar == '*')
                tbpassword.PasswordChar = '\0'; // Show the password
            else
                tbpassword.PasswordChar = '*'; // Hide the password
        }
    }
}
