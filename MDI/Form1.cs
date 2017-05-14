using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;

namespace MDI
{
    public partial class FormLogin : Form
    {
        //private MySqlConnection conn;
        private String myConnectionString;
        public FormLogin()
        {
            InitializeComponent();
            //    String myConnectionString = "server=127.0.0.1;uid=root;" + "pwd=1234;database=mdi;";
            //    conn = new MySqlConnection();
            myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
        }
        
        private void checkPass()
        {
            String sql = "select passwrd from users where users.username='" + textBoxUser.Text + "';";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();
                conn.Close();
                if (result != null && result.ToString().Equals(textBoxPass.Text))
                {
                    FormMain.username = textBoxUser.Text;
                    sql = "select groups from users where users.username='" + textBoxUser.Text + "';";
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    result = cmd.ExecuteScalar();
                    conn.Close();
                    FormMain.group = result.ToString();
                    this.Close();
                }
                else
                {
                    labelResult.Text = "Wrong username or password! Try again";
                    textBoxPass.Text = "";
                }
            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            checkPass();  
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                checkPass();
            }
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                checkPass();
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
