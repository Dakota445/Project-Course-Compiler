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
using System;
using MySql.Data.MySqlClient;

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

                    string query = "SELECT COUNT(*) FROM accounts WHERE StudentID = @StudentID AND PassW = @Password";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
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



        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=pccdatabase;Uid=root;Pwd=123456;";

            try
            {
                // Check if any of the parameter values is empty
                if (string.IsNullOrWhiteSpace(StudentIdBox.Text))
                {
                    MessageBox.Show("Please enter Student ID.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(NameBox.Text))
                {
                    MessageBox.Show("Please enter Full Name.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(DepartmentBox.Text))
                {
                    MessageBox.Show("Please enter Department.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(YearlevelBox.Text))
                {
                    MessageBox.Show("Please enter Year Level.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(PassWBox.Text))
                {
                    MessageBox.Show("Please enter Password.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO accounts (StudentID, FullName, Department, YearLevel, PassW) " +
                                    "VALUES (@StudentID, @FullName, @Department, @YearLevel, @PassW)";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StudentID", StudentIdBox.Text);
                    command.Parameters.AddWithValue("@FullName", NameBox.Text);
                    command.Parameters.AddWithValue("@Department", DepartmentBox.Text);
                    command.Parameters.AddWithValue("@YearLevel", YearlevelBox.Text);
                    command.Parameters.AddWithValue("@PassW", PassWBox.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Account Created Successfully.");

                    // Clear the fields after successful registration
                    StudentIdBox.Text = "";
                    NameBox.Text = "";
                    DepartmentBox.Text = "";
                    YearlevelBox.Text = "";
                    PassWBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            if (PassWBox.PasswordChar == '*')
                PassWBox.PasswordChar = '\0'; // Show the password
            else
                PassWBox.PasswordChar = '*'; // Hide the password
        }
    }
}
