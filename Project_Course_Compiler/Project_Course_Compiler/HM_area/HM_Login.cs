using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Course_Compiler.HM_area
{
    public partial class HM_Login : Form
    {
        public HM_Login()
        {
            InitializeComponent();
        }
        string consstring = Program.GlobalConsstring;
        string Coursee = "HM";
        private void return_btn_Click(object sender, EventArgs e)
        {
            Intro_Form intro = new Intro_Form();
            intro.Show();
            this.Hide();
        }

        private void Show_pass_btn_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (tbuser.Text == "" || tbpassword.Text == "")
            {
                MessageBox.Show("Username and Password cannot be empty");
            }
            else
            {
                LoginProcess();
            }
        }


        void LoginProcess()
        {
            try
            {
                string sql = "SELECT * FROM users WHERE StudentId = @StudentId AND Password = @Password";

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@StudentId", tbuser.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Password", tbpassword.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetString(2) == Coursee)
                            {
                                Program.username = reader.GetString(1);
                                Program.yearlevel = reader.GetString(3);
                                Program.department = reader.GetString(2);
                                MessageBox.Show($"You are logged-in as {Program.username}", "Login Successful");
                                HM_area.HM_Menu menu = new HM_area.HM_Menu();
                                menu.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password.");
                            }

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            HM_area.HM_Register register = new HM_area.HM_Register();
            register.Show();
            this.Hide();
        }

        private void Show_pass_btn_Click_1(object sender, EventArgs e)
        {
            if (tbpassword.PasswordChar == '\0')
                tbpassword.PasswordChar = '*';
            else
                tbpassword.PasswordChar = '\0';
        }

        private void HM_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Show_pass_btn_Click_2(object sender, EventArgs e)
        {
            if (tbpassword.PasswordChar == '\0')
                tbpassword.PasswordChar = '*';
            else
                tbpassword.PasswordChar = '\0';
        }

        private void return_btn_Click_1(object sender, EventArgs e)
        {
            Intro_Form intro = new Intro_Form();
            intro.Show();
            this.Hide();
        }
    }
}

