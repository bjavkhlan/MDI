using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MDI
{
    public partial class FormChat : Form
    {
        private TcpClient client;
        NetworkStream serverStream;
        //   private Socket listener;
        private const int port = 23456;
        public FormChat(TcpClient cli)
        {
            InitializeComponent();
            client = cli;
            serverStream = client.GetStream();

            Thread th = new Thread(getMessage);
            th.IsBackground = true;
            th.Start();
           // getMessage();
        }

        private void getMessage() {
            while (true) {
                serverStream = client.GetStream();
                int buffSize = 1024;
                byte[] inStream = new byte[10025];
               // buffSize = client.ReceiveBufferSize;
                //MessageBox.Show(buffSize.ToString());
                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                richTextBox1.Text += returndata;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(FormMain.username+": "+textBox1.Text + '\n');
            
            richTextBox1.Text += FormMain.username + ": " + textBox1.Text + '\n';
            textBox1.Text = "";

            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
    }
}
