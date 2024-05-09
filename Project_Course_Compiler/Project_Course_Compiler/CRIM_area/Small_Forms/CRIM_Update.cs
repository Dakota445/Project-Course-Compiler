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

namespace Project_Course_Compiler.CRIM_area.Small_Forms
{
    public partial class CRIM_Update : Form
    {
        public CRIM_Update(string Stored_ID)
        {
            InitializeComponent();
            InitializeComponent();
            Old_ID = Stored_ID;
            loadCourses(Stored_ID);
        }
        string Old_ID;
        string consstring = Program.GlobalConsstring;
        void loadCourses(string Stored_ID)
        {
            string sql = "SELECT * FROM Projects WHERE Identifier = @ID";

            using (MySqlConnection con = new MySqlConnection(consstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", Stored_ID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        titlebox.Text = reader.GetString(2);
                        descriptionbox.Text = reader.GetString(4);
                        urlbox.Text = reader.GetString(6);
                    }
                }
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (titlebox.Text == "" || descriptionbox.Text == "" || urlbox.Text == "")
            {
                MessageBox.Show("Please Fill-Up each Important Details.", "Attention");
            }
            else
            {
                Updateee();
            }
        }
        void Updateee()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string sql = "UPDATE Projects SET Title = @Title, Description = @Description, Url = @Url WHERE Identifier = @ID";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ID", Old_ID);
                    cmd.Parameters.AddWithValue("@Title", titlebox.Text);
                    cmd.Parameters.AddWithValue("@Description", descriptionbox.Text);
                    cmd.Parameters.AddWithValue("@Url", urlbox.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records were updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

