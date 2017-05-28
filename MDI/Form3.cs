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

namespace MDI
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            String sql = "select username from users;";
            String myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Label l = new Label();
                    l.Text = "*"+reader[0].ToString();
                    flowLayoutPanel1.Controls.Add(l);
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "select * from users where username ='"+textBox1.Text+"';";
            String myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[4].ToString();
                    textBox5.Text = reader[5].ToString();

                }
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  String sql = "delete from users where username='"+textBox6.Text+"';";
            String myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
              //  SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.ExecuteNonQuery();

               // sql = "insert into users values('" + textBox6.Text + "','" + textBox2.Text
            //    + "','" + textBox3.Text + "',NULL,'" + textBox4.Text + "','" + textBox5.Text + "');";
                string sql = "update users set fname = '" + textBox2.Text
               + "', lname = '" + textBox3.Text + "', passwrd = '" + textBox4.Text + "',groups = '" + textBox5.Text + "' where username = '"+textBox1.Text+"';";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                
                conn.Close();
                
            }
        }
    }
}
