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


namespace web
{
    public partial class BSITlogin : Form
    {
        public BSITlogin()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=pccdatabase;Uid=root;Pwd=123456;";
            string studentID = tbuser.Text;
            string password = tbpassword.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM bsit WHERE StudentID = @StudentID AND PassW = @Password";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        BSITPcc bSITPcc = new BSITPcc();
                        bSITPcc.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            BSITRegistration BSITRegistration = new BSITRegistration();
            BSITRegistration.Show();
            this.Hide();
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ProjectCC form1 = new ProjectCC();
            form1.Show();
            this.Close();
        }
    }
}

