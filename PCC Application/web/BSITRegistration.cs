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
    public partial class BSITRegistration : Form
    {
        public BSITRegistration()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {


            string connectionString = "Server=localhost;Database=pccdatabase;Uid=root;Pwd=123456;";

            try
            {
                // Check if any of the parameter values is empty
                if (string.IsNullOrWhiteSpace(StudentIdBox.Text))
                {
                    MessageBox.Show("Please enter your Student ID.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(NameBox.Text))
                {
                    MessageBox.Show("Please enter your Full Name.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(DepartmentBox.Text))
                {
                    MessageBox.Show("Please enter your  Department.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(YearlevelBox.Text))
                {
                    MessageBox.Show("Please enter your Year Level.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(PassWBox.Text))
                {
                    MessageBox.Show("Please enter your Password.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string checkIDQuery = "SELECT COUNT(*) FROM bsit WHERE StudentID = @StudentID";
                    MySqlCommand checkIDCmd = new MySqlCommand(checkIDQuery, connection);
                    checkIDCmd.Parameters.AddWithValue("@StudentID", StudentIdBox.Text);
                    int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Student ID already exists. Please use a different ID.");
                        return;
                    }

                    string query = "INSERT INTO bsit (StudentID, FullName, Department, YearLevel, PassW) " +
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (PassWBox.PasswordChar == '*')
                PassWBox.PasswordChar = '\0'; // Show the password
            else
                PassWBox.PasswordChar = '*'; // Hide the password
        }

        private void BSITRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSITlogin BSITlogin = new BSITlogin();
            BSITlogin.Show();
            this.Hide();
        }

        private void BSITRegistration_Load(object sender, EventArgs e)
        {

        }

        private void YearlevelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StudentIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PassWBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
