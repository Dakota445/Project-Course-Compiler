using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using YourNamespace;

namespace web
{
    public partial class BSITCompiler : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=pccdatabase;Uid=root;Pwd=123456;";

        public BSITCompiler()
        {
            InitializeComponent();
            InitializeConnection();
            refreshTable();
        }

        private void InitializeConnection()
        {
            connection = new MySqlConnection(connectionString);
        }


        void refreshTable()
        {
            try
            {
                dataGridView1.Rows.Clear();
                string sql = "SELECT * FROM bsitcompileprojects";
                                  

                List<string[]> rowData = new List<string[]>(); // Store rows data

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Store each row's data in rowData list
                            rowData.Add(new string[]
                            {
                                reader["Project_Title"].ToString(),
                                reader["Project_Description"].ToString(),
                                reader["Date"].ToString(),
                                reader["Year_Level"].ToString(),
                                reader["url"].ToString(),
                            });
                        }
                    }
                }

                // Sort the rowData list based on the first letter of the student's name
                rowData.Sort((x, y) => x[0][0].CompareTo(y[0][0]));

                // Add sorted rows to DataGrid
                foreach (string[] row in rowData)
                {
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button14_Click_1(object sender, EventArgs e)
        {
            BSITcompileprojects bSITcompileprojects = new BSITcompileprojects();
            bSITcompileprojects.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSITlogin BSITlogin = new BSITlogin();
            BSITlogin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BSITlogin BSITlogin = new BSITlogin();
            BSITlogin.Show();
            this.Hide();
        }

        private void BSITPcc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BSITarchieve BSITarchieve = new BSITarchieve();
            BSITarchieve.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BSITProjectcompiler BSITProjectcompiler = new BSITProjectcompiler();
            BSITProjectcompiler.Show();
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BSITProjectcompiler bSITProjectcompiler = new BSITProjectcompiler();
            bSITProjectcompiler.Show();
            this.Hide();
        }

        private void BSITCompiler_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Other event handlers...
    }
}
