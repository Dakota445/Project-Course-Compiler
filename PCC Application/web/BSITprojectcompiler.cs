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
    public partial class BSITProjectcompiler : Form
    {
        public BSITProjectcompiler()
        {
           
            InitializeComponent();
            refreshTable();


        }
        private const string _connectionString = "Server=localhost;Database=pccdatabase;Uid=root;Pwd=123456;";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BSITCompiler form6it = new BSITCompiler();
            form6it.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSITCompiler bSITCompiler = new BSITCompiler();
            bSITCompiler.Show();
            this.Hide();    
        }

        private void BSITcompiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        void refreshTable()
        {
            try
            {
                dataGridView1.Rows.Clear();
                string sql = "SELECT * FROM bsitcompileprojects";


                List<string[]> rowData = new List<string[]>(); // Store rows data

                using (MySqlConnection con = new MySqlConnection(_connectionString))
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


    }

}
