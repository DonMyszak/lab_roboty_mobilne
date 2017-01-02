using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool connect_button = false, klawiatura = false;
        TcpClient client;
        NetworkStream stream;
        Thread sThread;
        public string ramka_wys, ramka_odb, adres, port;

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            connect_button = false;
            stream.Close();
            client.Close();

        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            client = new TcpClient();
            connect_button = true;
            adres = textBox1.Text;
            ConnectToRobot();
            sThread = new Thread(new ThreadStart(SendAndReceive));
            sThread.Start();

        }

        public void ConnectToRobot()
        {
            try
            {
                client.Connect(adres, 8000);
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SendAndReceive()
        {
            while (connect_button)
            {
                stream = client.GetStream();
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(ramka_wys);
                stream.Write(data, 0, data.Length);
                Thread.Sleep(500);
                data = new Byte[28];
                Int32 bytes = stream.Read(data, 0, data.Length);
                ramka_odb = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            }
        }

        private void Klawiatura_Unchecked(object sender, RoutedEventArgs e)
        {
            klawiatura = false;
            ramka_wys = "[010000]";
        }

        public void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox3.Text = ramka_odb;
        }

        private void Klawiatura_Checked(object sender, RoutedEventArgs e)
        {
            klawiatura = true;
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W && klawiatura)
            {
                ramka_wys = "[015050]";
                textBox4.Text = ramka_wys;
            }

            if (e.Key == Key.S && klawiatura)
            {
                ramka_wys = "[018080]";
                textBox4.Text = ramka_wys;
            }

            if (e.Key == Key.A && klawiatura)
            {
                ramka_wys = "[010050]";
                textBox4.Text = ramka_wys;
            }

            if (e.Key == Key.D && klawiatura)
            {
                ramka_wys = "[015000]";
                textBox4.Text = ramka_wys;

            }
            if (e.Key == Key.X && klawiatura)
            {
                ramka_wys = "[010000]";
                textBox4.Text = ramka_wys;

            }

        }


        public MainWindow()
        {
            InitializeComponent();
            ramka_wys = "[000000]";
        }
    }
}
