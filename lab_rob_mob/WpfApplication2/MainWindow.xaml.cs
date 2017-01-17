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
using System.Timers;
using System.Windows.Threading;


namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pp;
        bool connect_button = false, klawiatura = false;
        TcpClient client;
        NetworkStream stream;
        Thread sThread;
        public string ramka_wys, ramka_odb, aa, adres, port;
        private System.Windows.Threading.DispatcherTimer timer;

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            connect_button = false;
            ramka_wys = "[010000]";
            textBox_status.Text = "Rozłączony";

        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            client = new TcpClient();
            connect_button = true;
            adres = textBox1.Text;
            ConnectToRobot();
            textBox_status.Text = "Połączony";
            sThread = new Thread(new ThreadStart(SendAndReceive));
            sThread.Start();

        }

        public void ConnectToRobot()
        {
            try
            {
                client.Connect(adres, 8000);
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
                data = new Byte[28];
                Int32 bytes = stream.Read(data, 0, data.Length);
                ramka_odb = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                AppendTextBox(ramka_odb);
                Thread.Sleep(250);
            }
            if (!connect_button)
            {
                stream.Close();
                client.Close();

            }
        }

        private void Klawiatura_Unchecked(object sender, RoutedEventArgs e)
        {
            klawiatura = false;
            ramka_wys = "[010000]";
            textBox4.Text = ramka_wys;
        }

        public void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Klawiatura_Checked(object sender, RoutedEventArgs e)
        {
            klawiatura = true;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W && klawiatura)
            {
                ramka_wys = "[011515]";
                textBox4.Text = ramka_wys;
            }

            if (e.Key == Key.S && klawiatura)
            {
                ramka_wys = "[01E6E6]";
                textBox4.Text = ramka_wys;
            }

            if (e.Key == Key.A && klawiatura)
            {
                ramka_wys = "[010015]";
                textBox4.Text = ramka_wys;
            }

            if (e.Key == Key.D && klawiatura)
            {
                ramka_wys = "[011500]";
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
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            ramka_wys = "[010000]";
        }
        public void AppendTextBox(string value)
        {
            if (Dispatcher.CheckAccess())
            {
                this.Dispatcher.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            aa = value;
        }

        void timer_Tick(object sender, EventArgs e)
        {
                 textBox3.Text = aa;
        }

    }

}
