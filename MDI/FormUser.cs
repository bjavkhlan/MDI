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
    public partial class FormUser : Form
    {

        TextBox[] salary= new TextBox[12];
        String myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
        String imagePath = "C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\image\\";
        public FormUser()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            salary[0] = textBox1;
            salary[1] = textBox2;
            salary[2] = textBox3;
            salary[3] = textBox4;
            salary[4] = textBox5;
            salary[5] = textBox6;
            salary[6] = textBox7;
            salary[7] = textBox8;
            salary[8] = textBox9;
            salary[9] = textBox10;
            salary[10] = textBox11;
            salary[11] = textBox12;
            for (int i = 0; i < 12; i++) salary[i].Text = "0";

            String sql = "select * from salary where username='" + FormMain.username + "';";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    for (int i = 0; i < 12; i++) salary[i].Text = ((int)reader1[i+1]).ToString();
                }
                reader1.Close();

                sql = "select * from users where username='" + FormMain.username + "';";
                cmd = new SqlCommand(sql, conn);
                

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    labelUsername.Text = (string)reader[0];
                    labelFname.Text = (string)reader[1];
                    labelLname.Text = (string)reader[2];
                    labelBday.Text = reader[3].ToString();
                    labelGroup.Text = (string)reader[5];
                }
                conn.Close();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            int MH = ((PictureBox)sender).Height;
            int MW = ((PictureBox)sender).Width;
            int H = MH / 12;
            int W = MW / 14;
            Pen pen = new Pen(Color.Green, 20);
            Pen border = new Pen(Color.Black);
            G.DrawRectangle(border, W, 0, MW-W-1, MH-H);
            Font font = new Font("Arial", 8);
            int BaseH = 20+(int)(G.MeasureString((100).ToString(), font).Height);
            for (int i = 0; i <= 10; i ++)
                G.DrawString((i * 100).ToString(), font, new SolidBrush(Color.Black), new Point(W-(int)(G.MeasureString((i*100).ToString(), font).Width), MH-BaseH-i * H));
            
            for (int i = 1; i <= 12; i++)
                G.DrawString(i.ToString(), font, new SolidBrush(Color.Black), new Point(W*(i+1), MH-H));
            for (int i = 0; i < 12; i++)
                G.DrawLine(pen, W*(i+2)+5, MH-H-(H*(int.Parse(salary[i].Text)))/100, W*(i+2)+5, MH-H);
        }
        
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            String sql = "delete from salary where username = '" + FormMain.username + "';";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                sql = "insert into salary values('" + FormMain.username+"'";
                for (int i = 0; i < 12; i++) sql += "," + salary[i].Text;
                sql += ");";
              //  MessageBox.Show(sql);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Invalidate();
            Update();
            Refresh();
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            string imagepath;
            string sql = "select imagepath from images where username = '" + FormMain.username + "';";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                imagepath = (string)cmd.ExecuteScalar();
                conn.Close();
            }
            //MessageBox.Show(imagepath);
            Bitmap image = (Bitmap)Image.FromFile( imagepath );
            e.Graphics.DrawImage(image, 0, 0, 200, 200);
            image.Dispose();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            FileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = (Bitmap)Image.FromFile(dialogOpen.FileName);
                image = new Bitmap(image, 400, 400);
                Bitmap stamp = (Bitmap)Image.FromFile(imagePath+"new.png");
                Graphics G = Graphics.FromImage(image);
                G.DrawImage(stamp, 0, 0, 100, 100);
                Font font = new Font("Arial", 10);
                //G.DrawString(DateTime.Today.ToString(), font, new SolidBrush(Color.Yellow), 100, 100);
                G.DrawString(DateTime.Today.ToString("d"), font, new SolidBrush(Color.Yellow), 400-(G.MeasureString((DateTime.Today).ToString("d"), font).Width), 400 - (G.MeasureString((DateTime.Today).ToString("d"), font).Height));
                if (System.IO.File.Exists(imagePath + FormMain.username + ".jpg"))
                    System.IO.File.Delete(imagePath + FormMain.username + ".jpg");
                image.Save(imagePath + FormMain.username + ".jpg");
                image.Dispose();
                stamp.Dispose();
                
                string sql = "delete from images where username = '"+FormMain.username+"';";
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    sql = "insert into images values('"+FormMain.username+"','"+ imagePath + FormMain.username + ".jpg" + "');";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }


            Invalidate();
            Update();
            Refresh();
        }
    }
}
