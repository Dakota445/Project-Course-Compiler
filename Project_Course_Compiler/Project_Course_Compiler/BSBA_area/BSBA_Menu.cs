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
    public partial class BSBA_Menu : Form
    {
        public BSBA_Menu()
        {
            InitializeComponent();
            refreshTable();
            DataGridView1.CellClick += DataGrid_CellClick; // Attach event handler
            DataGridView1.ClearSelection();
        }
        string consstring = Program.GlobalConsstring;
        string Stored_ID;
        string Titlee;
        string Stored_URL;
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int overallRow = DataGridView1.RowCount;
            if (e.RowIndex >= 0 && e.RowIndex <= overallRow - 2)
            {
                DataGridViewRow selectedRow = DataGridView1.Rows[e.RowIndex];
                Stored_ID = selectedRow.Cells["ID"].Value.ToString();
                Titlee = selectedRow.Cells["Title"].Value.ToString();
                Stored_URL = selectedRow.Cells["URL"].Value.ToString();
            }
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 118, 200);
        }
        void refreshTable()
        {
            DataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 255);

            try
            {
                DataGridView1.Rows.Clear();

                string sql = "SELECT * FROM Projects";

                List<string[]> rowData = new List<string[]>();

                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string archive_stat = reader.GetString(8);
                            string course = reader.GetString(7);
                            if (archive_stat == "0" && course == Program.department)
                            {
                                rowData.Add(new string[]
                            {
                            reader["Identifier"].ToString(),
                            reader["Created_By"].ToString(),
                            reader["Title"].ToString(),
                            reader["Date"].ToString(),
                            reader["Description"].ToString(),
                            reader["YearLevel"].ToString(),
                            reader["Url"].ToString()
                            });
                            }
                        }
                    }
                }
                rowData.Sort((x, y) => x[0][0].CompareTo(y[0][0]));

                foreach (string[] row in rowData)
                {
                    DataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void return_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log-out?", "Confirming Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Intro_Form intro = new Intro_Form();
                intro.Show();
                this.Hide();
            }
        }

        private void Archivebtn_Click(object sender, EventArgs e)
        {
            Archive_Form view = new Archive_Form();
            view.ShowDialog();
            refreshTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BSBA_area.Small_Forms.BSBA_Add add = new BSBA_area.Small_Forms.BSBA_Add();
            add.ShowDialog();
            refreshTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Small_Forms.BSBA_Update update = new Small_Forms.BSBA_Update(Stored_ID);
            update.ShowDialog();
            refreshTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{Titlee}' from the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Set Archive_Status to 1
                    using (MySqlConnection con = new MySqlConnection(consstring))
                    {
                        con.Open();
                        string sql = "UPDATE Projects SET Archive = @Archive WHERE Identifier = @ID";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@ID", Stored_ID);
                        cmd.Parameters.AddWithValue("@Archive", "1");
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    refreshTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"error: {ex}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_URL_Form show = new Show_URL_Form(Stored_URL);
            show.ShowDialog();
        }

        private void BSBA_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
