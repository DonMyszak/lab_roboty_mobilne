using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        TcpClient client = new TcpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string adres;
            adres = Convert.ToString(textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string port;
            port = Convert.ToString(textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendAndReceive();
        }

        public void SendAndReceive()
        {
            NetworkStream stream = client.GetStream();
            String responseData = String.Empty;
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(textBox3.Text);
            stream.Write(data, 0, data.Length);
            data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            textBox4.Text = responseData;
        }

        public void ConnectAsClient()
        {

            client.Connect(IPAddress.Parse(textBox1.Text), Convert.ToInt16(textBox2.Text));

        }

        public void DisconnectAsClient()
        {
            client.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisconnectAsClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
