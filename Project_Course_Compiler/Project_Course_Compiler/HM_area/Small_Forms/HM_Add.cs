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

namespace Project_Course_Compiler.HM_area.Small_Forms
{
    public partial class HM_Add : Form
    {
        public HM_Add()
        {
            InitializeComponent();
        }
        string consstring = Program.GlobalConsstring;
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titlebox.Text) ||
                string.IsNullOrWhiteSpace(descriptionbox.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                string.IsNullOrWhiteSpace(urlbox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(consstring))
                {
                    con.Open();

                    string sql = "INSERT INTO Projects (Created_By, Title, Date, Description, URL, YearLevel, Department, Archive) VALUES (@Created_By,@Title, @Date, @Description, @URL, @YearLevel, @Department, @Archive)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Created_By", Program.username);
                    cmd.Parameters.AddWithValue("@Title", titlebox.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@Description", descriptionbox.Text);
                    cmd.Parameters.AddWithValue("@YearLevel", Program.yearlevel);
                    cmd.Parameters.AddWithValue("@URL", urlbox.Text);
                    cmd.Parameters.AddWithValue("@Department", Program.department);
                    cmd.Parameters.AddWithValue("@Archive", "0");
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Project Successfully Added");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
    }

