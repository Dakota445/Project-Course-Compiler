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

namespace Project_Course_Compiler.BSBA_area
{
    public partial class BSBA_Register : Form
    {
        public BSBA_Register()
        {
            InitializeComponent();
        }
        string consstring = Program.GlobalConsstring;
        string Courseee = "BSBA";
        private void return_btn_Click(object sender, EventArgs e)
        {
            Intro_Form intro = new Intro_Form();
            intro.Show();
            this.Hide();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            BSBA_area.BSBA_Register register = new BSBA_area.BSBA_Register();
            register.Show();
            this.Hide();
        }

        private void return_btn_Click_1(object sender, EventArgs e)
        {
            BSBA_area.BSBA_Login login = new BSBA_area.BSBA_Login();
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

        private void BSBA_Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }
   

