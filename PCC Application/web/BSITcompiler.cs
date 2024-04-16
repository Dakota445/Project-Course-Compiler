using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace web
{
    public partial class BSITPcc : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=pccdatabase;Uid=root;Pwd=123456;";

        public BSITPcc()
        {
            InitializeComponent();
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        private void BSITPcc_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM bsitcompiler";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();

                    conn.Open();
                    dataAdapter.Fill(ds);
                    conn.Close();

                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(txtYearLevel.Text) ||
                    string.IsNullOrWhiteSpace(txtFileType.Text) || string.IsNullOrWhiteSpace(txtuploadas.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                connection.Open();

                string query = "INSERT INTO bsitcompiler (Project_Title, Project_Description, Date, YearLevel, File_type, Upload_as) " +
                               "VALUES (@Project_Title, @Project_Description, @Date, @YearLevel, @File_type, @Upload_as)";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Project_Title", txtTitle.Text);
                command.Parameters.AddWithValue("@Project_Description", txtDescription.Text);
                command.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@YearLevel", txtYearLevel.Text);
                command.Parameters.AddWithValue("@File_type", txtFileType.Text);
                command.Parameters.AddWithValue("@Upload_as", txtuploadas.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Data inserted successfully.");

                ClearInputFields();

                LoadDataGrid();
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
            txtYearLevel.Text = "";
            txtFileType.Text = "";
            txtuploadas.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "All files (*.*)|*.*|PDF files (*.pdf)|*.pdf|Word documents (*.doc;*.docx)|*.doc;*.docx|Text files (*.txt)|*.txt|PowerPoint presentations (*.ppt;*.pptx)|*.ppt;*.pptx|Excel files (*.xls;*.xlsx)|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    txtFileType.AppendText(filename + Environment.NewLine);
                }
            }
        }

        // Other event handlers...
    }
}
