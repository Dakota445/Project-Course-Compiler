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
    public partial class BSITcompileprojects : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=pccdatabase;Uid=root;Pwd=123456;";

        public BSITcompileprojects()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(txtboxurl.Text) ||
                    string.IsNullOrWhiteSpace(txtYearLevel.Text)) 
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                connection.Open();

                string query = "INSERT INTO bsitcompileprojects (Project_Title, Project_Description, Date, URL , YearLevel) " +
                               "VALUES (@Project_Title, @Project_Description, @Date , @URL , @YearLevel)";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Project_Title", txtTitle.Text);
                command.Parameters.AddWithValue("@Project_Description", txtDescription.Text);
                command.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@URL", txtboxurl.Text);
                command.Parameters.AddWithValue("@YearLevel", txtYearLevel.Text);
                


                command.ExecuteNonQuery();

                MessageBox.Show("Data inserted successfully.");

                ClearInputFields();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            dateTimePicker1.Text = "";
            txtboxurl.Text = "";
            txtYearLevel.Text = "";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSITPcc BSITPcc = new BSITPcc();
            BSITPcc.Show();
            this.Hide();    
        }

        private void BSITcompileprojects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BSITcompileprojects_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

