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
        private SqlConnection conn;
        //private MySqlConnection conn;
        private FormAdmin formAdmin;
        private FormManager formManager;
        public FormLogin()
        {
            InitializeComponent();
            //    String myConnectionString = "server=127.0.0.1;uid=root;" + "pwd=1234;database=mdi;";
            //    conn = new MySqlConnection();
            conn = new SqlConnection();
            String myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
            conn.ConnectionString = myConnectionString;

            
        }
        
        
        private void buttonlogin_Click(object sender, EventArgs e)
        {
           

            String sql = "select passwrd from users where users.username='"+textBoxUser.Text+"';";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();
            conn.Close();


            if (result != null && result.ToString().Equals(textBoxPass.Text) )
            {
                formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide();
                MessageBox.Show(result.ToString());
            }

        }

        private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
