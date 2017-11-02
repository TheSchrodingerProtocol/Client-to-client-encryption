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
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace BlackHole_Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Ping_manual()
        {

            TB_IP.ReadOnly = false;
            if (string.IsNullOrWhiteSpace(TB_IP.Text)) { TB_ERROR.AppendText("Error no ip in IP-field" +"\r\n"); TB_ERROR.AppendText("\r\n"); return; }


            Ping ping_send_manual = new Ping();
            IPAddress iPAddress = IPAddress.Parse(TB_IP.Text);
            PingReply reply = ping_send_manual.Send(iPAddress);

          
            
            if (reply.Status == IPStatus.Success)
            {
                TB_PING.AppendText("Gateway IP: " + reply.Address.ToString() + "\r\n");
                TB_PING.AppendText("Round trip time: " + reply.RoundtripTime + "\r\n");
                TB_PING.AppendText("TTL: " + reply.Options.Ttl + "\r\n");
                TB_PING.AppendText("Do not fragment: " + reply.Options.DontFragment + "\r\n");
                TB_PING.AppendText("Buffer size: " + reply.Buffer.Length + "\r\n");
                TB_PING.AppendText("Ping completed game on!" + "\r\n");
                TB_PING.AppendText("\r\n");

                TB_IP.Text = iPAddress.ToString();
                TB_IP.Cursor = Cursors.Arrow;
                TB_IP.ReadOnly = true;
                TB_ERROR.Clear();
            }

            else
            {
                TB_PING.AppendText("Error type: " + reply.Status.ToString() +"\r\n");
                TB_ERROR.AppendText("Check internet / network connection !");
            }
            

        }

        private void Auto_config()
        {

            foreach (NetworkInterface inTerface in NetworkInterface.GetAllNetworkInterfaces())
                if (inTerface.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation ADDR in inTerface.GetIPProperties().GatewayAddresses)
                        TB_IP.Text = ADDR.Address.ToString();
                }

        }

        public bool timer_value;
        public bool Connection_timer(bool timer)
        {

            System.Timers.Timer Con_timers = new System.Timers.Timer();
            Con_timer.Tick += new EventHandler(contimer_Tick);
          //  Con_timer.Interval = new TimeSpan(0,0,3);

            if (timer.Equals(true))
            {
                Con_timer.Start();
                timer_value = true;
            }

            if (timer.Equals(false))
            {
                Con_timer.Stop();
                timer_value = false;

            }

            return (bool)(timer) && (bool)(timer_value);


        }


        private void Payload()
        {

            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            
            try
            {
                client.Connect(TB_IP.Text, 80);
            }

            catch (Exception ex)
            {
                TB_ERROR.AppendText("Error : " + ex.Message);
            }

            if (client.Connected)
            {

                

                string message = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklnmopqrstuvwxyz";
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                TB_PING.AppendText("Sending: " + message);
                client.Send(buffer);



            }
        }
            private void BT_PING_Click(object sender, EventArgs e)
        {
          
            Ping_manual();
        }

        private void TB_PING_TextChanged(object sender, EventArgs e)
        {
            TB_PING.SelectionStart = TB_PING.Text.Length;
            TB_PING.ScrollToCaret();
        }

        private void TB_ERROR_TextChanged(object sender, EventArgs e)
        {
            TB_ERROR.SelectionStart = TB_ERROR.Text.Length;
            TB_ERROR.ScrollToCaret();
        }

        private void BT_auto_config_Click(object sender, EventArgs e)
        {
            Auto_config();
        }

        private void BT_LAUNCH_Click(object sender, EventArgs e)
        {

        }

        private void contimer_Tick(object sender, EventArgs e)
        {

        }

    }
}
