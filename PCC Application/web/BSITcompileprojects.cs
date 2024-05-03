using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using web;

namespace YourNamespace
{
    public partial class BSITcompileprojects : Form
    {
        private readonly MySqlConnection _connection;
        private const string _connectionString = "Server=localhost;Database=pccdatabase;Uid=root;Pwd=123456;";

        public BSITcompileprojects()
        {
            InitializeComponent();
            _connection = new MySqlConnection(_connectionString);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Projecttitle.Text) ||
                    string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                    string.IsNullOrWhiteSpace(txtboxurl.Text) ||
                    string.IsNullOrWhiteSpace(txtYearLevel.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                _connection.Open();

                string query = "INSERT INTO bsitcompileprojects (Project_Title, Project_Description, Date, URL , Year_Level) " +
                               "VALUES (@Project_Title, @Project_Description, @Date , @URL , @YearLevel)";

                MySqlCommand command = new MySqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Project_Title", Projecttitle.Text);
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
                _connection.Close();
            }
        }

        private void ClearInputFields()
        {
            Projecttitle.Text = "";
            txtDescription.Text = "";
            dateTimePicker1.Value = DateTime.Now; // Reset date time picker to current date
            txtboxurl.Text = "";
            txtYearLevel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSITCompiler bsitCompiler = new BSITCompiler();
            bsitCompiler.Show();
            this.Hide();
        }

        private void BSITcompileprojects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BSITcompileprojects_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BSITCompiler bSITCompiler = new BSITCompiler();
            bSITCompiler.Show();
            this.Hide();
        }
    }
}
