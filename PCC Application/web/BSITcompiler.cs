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


    
   
        

        private void button14_Click_1(object sender, EventArgs e)
        {
            BSITcompileprojects BSITcompileprojects = new BSITcompileprojects();
            BSITcompileprojects.Show();
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
            BSITcompiler BSITcompiler = new BSITcompiler();
            BSITcompiler.Show();
            this.Hide();    
        }

        // Other event handlers...
    }
}
