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

namespace Project_Course_Compiler.TEP_area
{
    public partial class TEP_Register : Form
    {
        public TEP_Register()
        {
            InitializeComponent();
        }
        string consstring = Program.GlobalConsstring;
        string Courseee = "TEP";
        private void return_btn_Click(object sender, EventArgs e)
        {
            TEP_area.TEP_Login login = new TEP_area.TEP_Login();
            login.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
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
                else if (string.IsNullOrWhiteSpace(yearbox.Text))
                {
                    MessageBox.Show("Please enter your Year Level.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(PassWBox.Text))
                {
                    MessageBox.Show("Please enter your Password.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(consstring))
                {
                    connection.Open();
                    string checkIDQuery = "SELECT COUNT(*) FROM users WHERE StudentId = @StudentId";
                    MySqlCommand checkIDCmd = new MySqlCommand(checkIDQuery, connection);
                    checkIDCmd.Parameters.AddWithValue("@StudentId", StudentIdBox.Text);
                    int count = Convert.ToInt32(checkIDCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Student ID already exists. Please use a different ID.");
                        return;
                    }

                    string query = "INSERT INTO users (StudentID, Fullname, Department, YearLevel, Password) " +
                                    "VALUES (@StudentID, @Fullname, @Department, @YearLevel, @Password)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StudentID", StudentIdBox.Text.ToUpper());
                    command.Parameters.AddWithValue("@FullName", NameBox.Text);
                    command.Parameters.AddWithValue("@Department", Courseee);
                    command.Parameters.AddWithValue("@YearLevel", yearbox.Text);
                    command.Parameters.AddWithValue("@Password", PassWBox.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Account Created Successfully.");

                    StudentIdBox.Text = "";
                    NameBox.Text = "";
                    yearbox.Text = "";
                    PassWBox.Text = "";
                    yearbox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Show_Pass_btn_Click(object sender, EventArgs e)
        {
            if (PassWBox.PasswordChar == '\0')
                PassWBox.PasswordChar = '*';
            else
                PassWBox.PasswordChar = '\0';
        }

        private void TEP_Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
