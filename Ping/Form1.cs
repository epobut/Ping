using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;

namespace Ping
{
    public partial class Form1 : Form
    {
        // Counts the pings
        private int pingsSent;
        // Can be used to notify when the operation completes
        AutoResetEvent resetEvent = new AutoResetEvent(false);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            // Reset the number of pings
            pingsSent = 0;
            // Clear the textbox of any previous content
            txtResponse.Clear();
            txtResponse.Text += "Pinging " + txtIP.Text + " with 32 bytes of data:\r\n\r\n";
            // Send the ping
            SendPing();
        }

        private void SendPing()
        {
            System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();

            // Create an event handler for ping complete
            pingSender.PingCompleted += new PingCompletedEventHandler(pingSender_Complete);

            // Create a buffer of 32 bytes of data to be transmitted.
            byte[] packetData = Encoding.ASCII.GetBytes("................................");

            // Jump though 50 routing nodes tops, and don't fragment the packet
            PingOptions packetOptions = new PingOptions(50, true);

            // Send the ping asynchronously
            pingSender.SendAsync(txtIP.Text, 5000, packetData, packetOptions, resetEvent);
        }

        private void pingSender_Complete(object sender, PingCompletedEventArgs e)
        {
            // If the operation was canceled, display a message to the user.
            if (e.Cancelled)
            {
                txtResponse.Text += "Ping was canceled...\r\n";

                // The main thread can resume
                ((AutoResetEvent)e.UserState).Set();
            }
            else if (e.Error != null)
            {
                txtResponse.Text += "An error occured: " + e.Error + "\r\n";

                // The main thread can resume
                ((AutoResetEvent)e.UserState).Set();
            }
            else
            {
                PingReply pingResponse = e.Reply;
                // Call the method that displays the ping results, and pass the information with it
                ShowPingResults(pingResponse);
            }
        }

        public void ShowPingResults(PingReply pingResponse)
        {
            if (pingResponse == null)
            {
                // We got no response
                txtResponse.Text += "There was no response.\r\n\r\n";
                return;
            }
            else if (pingResponse.Status == IPStatus.Success)
            {
                // We got a response, let's see the statistics
                txtResponse.Text += "Reply from " + pingResponse.Address.ToString() + ": bytes=" + pingResponse.Buffer.Length + " time=" + pingResponse.RoundtripTime + " TTL=" + pingResponse.Options.Ttl + "\r\n";
            }
            else
            {
                // The packet didn't get back as expected, explain why
                txtResponse.Text += "Ping was unsuccessful: " + pingResponse.Status + "\r\n\r\n";
            }
            // Increase the counter so that we can keep track of the pings sent
            pingsSent++;
            // Send 4 pings
            if (pingsSent < 4)
            {
                SendPing();
            }
        }
    }
}