using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTest
{
    public partial class MainForm : Form
    {
        private Random _random = new Random();
        private UdpClient _listen = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
        }

        private void Log(string text)
        {
            logTextBox.Text += text + "\r\n";
            logTextBox.SelectionStart = logTextBox.Text.Length;
            logTextBox.ScrollToCaret();
            logTextBox.Refresh();
        }

        private void sendPacketButton_Click(object sender, EventArgs e)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            if (!IPAddress.TryParse(ipTextBox.Text, out var address))
            {
                Log("IP parse failed");
                return;
            }
            var endpoint = new IPEndPoint(address, (int)portNumericUpDown.Value);
            var sendBuffer = new byte[(int)sizeNumericUpDown.Value];
            _random.NextBytes(sendBuffer);
            try
            {
                socket.SendTo(sendBuffer, endpoint);
            }
            catch (Exception ex)
            {
                Log("Failed to send packet:\r\n\r\n" + ex.ToString());
                return;
            }
            Log("Sent");
        }

        private async void listenButton_Click(object sender, EventArgs e)
        {
            if (_listen != null)
            {
                listenButton.Text = "Listen";
                ipTextBox.Enabled = portNumericUpDown.Enabled = sizeNumericUpDown.Enabled = sendPacketButton.Enabled = true;
                try
                {
                    _listen.Close();
                    _listen.Dispose();
                }
                catch (Exception ex)
                {
                    Log("Failed to dispose socket:\r\n\r\n" + ex.ToString());
                }
                _listen = null;
                return;
            }
            listenButton.Text = "Stop listening";
            ipTextBox.Enabled = portNumericUpDown.Enabled = sizeNumericUpDown.Enabled = sendPacketButton.Enabled = false;
            try
            {
                _listen = new UdpClient((int)portNumericUpDown.Value);
                while (true)
                {
                    UdpReceiveResult receivedResults;
                    try
                    {
                        receivedResults = await _listen.ReceiveAsync();
                    }
                    catch (ObjectDisposedException)
                    {
                        Log("Stopped listening");
                        break;
                    }
                    Log($"Received {receivedResults.Buffer.Length} byte(s) from {receivedResults.RemoteEndPoint}");
                }
            }
            catch (Exception ex)
            {
                Log("Failed to listen:\r\n\r\n" + ex.ToString());
            }
        }
    }
}
