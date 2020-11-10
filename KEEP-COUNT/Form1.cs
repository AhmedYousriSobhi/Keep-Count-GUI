using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;


namespace KEEP_COUNT
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        public Form1()
        {
            InitializeComponent();
            myport = new SerialPort();
            timer1.Enabled = true;
            stop_btn.Visible = false;
        }

        private void Restart_btn_Click(object sender, EventArgs e)
        {
            // create new instance/object called info 
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
            Info.WindowStyle = ProcessWindowStyle.Hidden;
            Info.CreateNoWindow = true;
            Info.FileName = "cmd.exe";
            Process.Start(Info);
            Application.Exit();
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myport.Close();
                myport.PortName = ports_list.Text;
                myport.BaudRate = 9600;
                myport.Parity = Parity.None;
                myport.DataBits = 8;
                myport.StopBits = StopBits.One;
                myport.Open();
                myport.DataReceived += Myport_DataReceived;
                CONTROL_BOX.Visible = false;
            }
            catch (Exception ex)
            {                                           
                MessageBox.Show(ex.Message, "ERROR");            
            }
        }
        String Recieved;
        private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Recieved = (myport.ReadLine());
            this.Invoke(new EventHandler(read_data_from_port));
        }
        int counter_person=0;
        private void read_data_from_port(object sender, EventArgs e)
        {
            /*
            if (Convert.ToChar(Recieved) == 'a') counter_person++;//increment
            else if (Convert.ToChar(Recieved) == 'b') { counter_person--; if (counter_person < 0) counter_person = 0; }//decrement
            digit2_lb.Text = (counter_person / 10).ToString();
            digit1_lb.Text = (counter_person % 10).ToString();
            */
            digit2_lb.Text = (Convert.ToInt32(Recieved) / 10).ToString();
            digit1_lb.Text = (Convert.ToInt32(Recieved) % 10).ToString();
            //MessageBox.Show(Recieved);
        }

        int ok = 0; // variable used once only to add ports to comboBox1 at the beginning
        int prev_num_ports = 0;
        //*************************************************
        // function to get available ports
        void get_available_ports()
        {
            string[] ports = SerialPort.GetPortNames();
            int Ports_length = ports.Length;
            if (ok == 0) { ports_list.Items.AddRange(ports); ok = 1; prev_num_ports = Ports_length; }
            else if (Ports_length != prev_num_ports)
            {
                ports_list.Items.Clear();
                ports_list.Refresh();
                ports_list.Items.AddRange(ports);              
                prev_num_ports = Ports_length;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            get_available_ports();
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            CONTROL_BOX.Visible = true;
            myport.Close();
        }
    }
}
