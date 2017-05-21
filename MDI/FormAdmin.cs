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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "insert into users values('" + textBox1.Text + "','" + textBox2.Text
                + "','" + textBox3.Text + "',NULL,'" + textBox4.Text + "','" + textBox5.Text + "');";
            String myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
             //   MessageBox.Show(result.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = "insert into users values('" + textBox6.Text + "');";
            String myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
             //   MessageBox.Show(result.ToString());
            }
        }
    }
}

