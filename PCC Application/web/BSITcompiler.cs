using MySql.Data.MySqlClient;
using System;
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
        }

        private void InitializeConnection()
        {
            connection = new MySqlConnection(connectionString);
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

        // Other event handlers...
    }
}
