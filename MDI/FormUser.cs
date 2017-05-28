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
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace MDI
{

    public partial class FormUser : Form
    {

        private TextBox[] salary= new TextBox[12];
        private String myConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\mdi.mdf; Integrated Security = True; Connect Timeout = 30";
        private String imagePath = "C:\\Users\\Jagaa\\documents\\visual studio 2017\\Projects\\MDI\\MDI\\image\\";
     //   String[] inChatIp;
      //  int inChat = 0;
        private const int udpPort = 12345;
        private const int tcpPort = 23456;
        public FormUser()
        {
            InitializeComponent();
         //   this.WindowState = FormWindowState.Maximized;
           
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

            RefreshChatList();

            Thread listener = new Thread(StartListening);
            listener.IsBackground = true;
            listener.Start();
        }

        private void StartListening() {
            TcpListener listener = new TcpListener(IPAddress.Any, tcpPort);
            try
            {
                listener.Start();
                while (true)
                {
                    TcpClient handler = listener.AcceptTcpClient();
                   // Socket handler = listener.AcceptSocket();
                    FormChat chat = new FormChat(handler);


                    this.MdiParent.Invoke((MethodInvoker)(()=> {
                        chat.MdiParent = this.MdiParent;
                        chat.Show();
                    }));
                    //chat.Invoke((MethodInvoker)(()=>chat.Show()));
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }

        private void sendBroadcast(object sender, EventArgs e) {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress broadcast = IPAddress.Parse("192.168.1.255");
            byte[] sendbuf = Encoding.ASCII.GetBytes("HiChat");
            IPEndPoint ep = new IPEndPoint(broadcast, udpPort);
            s.SendTo(sendbuf, ep);
            MessageBox.Show("Broadcast Message Sent!");
        }

        private void RefreshChatList() {
          //  flowLayoutPanel2.Controls.Clear();
            Label header = new Label();
            header.Text = "Online Users:";
            header.ForeColor = Color.Green;
            header.Click += new EventHandler(sendBroadcast);
            flowLayoutPanel2.Controls.Add(header);


            
            Thread th = new Thread(() =>
            {

               // bool done = false;

                UdpClient listener = new UdpClient(udpPort);
                IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, udpPort);
                try
                {
                    while (true)
                    {
                        byte[] bytes = listener.Receive(ref groupEP);
                        string received = Encoding.Default.GetString(bytes);
                   //     MessageBox.Show(received);
                        if ( received == "HiChat")
                        {
                            //MessageBox.Show("Here");
                            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                            byte[] msg = Encoding.ASCII.GetBytes(FormMain.username);
                            soc.SendTo(msg, new IPEndPoint(groupEP.Address, udpPort));
                            //soc.SendTo(msg, new IPEndPoint(IPAddress.Parse("192.168.1.255"), udpPort));
                        }
                        else
                        {
                            //MessageBox.Show( received );
                           // inChatIp[inChat] = groupEP.Address.ToString();
                            Label label = new Label();
                            label.Text = received + ":" + groupEP.Address.ToString();
                            label.Click += new EventHandler(Chat);
                          //  MessageBox.Show(label.Text);
                            flowLayoutPanel2.Invoke((MethodInvoker)(()=> flowLayoutPanel2.Controls.Add(label)));
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    listener.Close();
                }
            });

            th.IsBackground = true;
            th.Start();
            
        }

        private void Chat(object sender, EventArgs e) {
            //MessageBox.Show(((Label)sender).Text);
            string[] str = (((Label)sender).Text).Split(':');
            //Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            TcpClient client = new TcpClient();
            try
            {
              //  MessageBox.Show(str[1]);
                client.Connect(IPAddress.Parse(str[1]), tcpPort);
               // IPEndPoint EP = new IPEndPoint( IPAddress.Parse(str[1]), tcpPort );
              //  soc.Bind(EP);
                FormChat chat = new FormChat(client);
                chat.MdiParent = this.MdiParent;
                chat.Show();

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
         }

        private void DrawBar(object sender, Graphics G) 
        {
            int MH = ((PictureBox)sender).Height;
            int MW = ((PictureBox)sender).Width;
            int H = MH / 12;
            int W = MW / 14;
            Pen pen = new Pen(Color.Green, 20);
            Pen border = new Pen(Color.Black);
            G.DrawRectangle(border, W, 0, MW-W-1, MH-H);
            Font font = new Font("Arial", 8);
            int BaseH = 20 + (int)(G.MeasureString((100).ToString(), font).Height);
            for (int i = 0; i <= 10; i ++)
                G.DrawString((i* 100).ToString(), font, new SolidBrush(Color.Black), new Point(W-(int)(G.MeasureString((i*100).ToString(), font).Width), MH-BaseH-i* H));
            
            for (int i = 1; i <= 12; i++)
                G.DrawString(i.ToString(), font, new SolidBrush(Color.Black), new Point(W*(i+1), MH-H));
            for (int i = 0; i< 12; i++)
                G.DrawLine(pen, W*(i+2)+5, MH-H-(H*(int.Parse(salary[i].Text)))/100, W* (i+2)+5, MH-H);
        
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Graphics G = e.Graphics;
            Thread th = new Thread(()=>DrawBar(sender, G));
            th.Start();
            th.Join();
           
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
