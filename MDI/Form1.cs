using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MDI
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            String myConnectionString = "server=127.0.0.1;uid=root;" + "pwd=1234;database=mdi;";
            conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            String sql = "select passwrd from users where users.username='"+textBoxUser.Text+"';";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();
            if (result != null && result.ToString().Equals(textBoxPass.Text) )
            {
                textResult.Text = "Here";
            }

        }
    }
}
