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

namespace ChatApp
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        private object textRemotePort;
        private object textRemoteIP;

        public Form1()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalIP.Text = GetLocalIP();
            textSendtoIP.Text = GetLocalIP();

        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0)
                {
                    byte[] recivedData = new byte[1464];

                    recivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncodeing = new ASCIIEncoding();
                    string recivedMessage = eEncodeing.GetString(recivedData);
                    string unincriptedmessage = "";
                    foreach (char c in recivedMessage)
                    {
                        char decripted = (char)(c - EncriptionKey.Value);

                        unincriptedmessage += decripted.ToString();
                    }

                    if (InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            listRecieved.Items.Add(textSendtoIP.Text + ": " + recivedMessage);
                            listRecieved.SelectedIndex = listRecieved.Items.Count - 1;
                            listRecieved.SelectedIndex = -1;
                        }));
                        
                    }else
                    {
                        listRecieved.Items.Add(textSendtoIP.Text + recivedMessage);
                        listRecieved.SelectedIndex = listRecieved.Items.Count - 1;
                        listRecieved.SelectedIndex = -1;
                    }


                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {

                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textSendtoIP.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                buttonConnect.Enabled = false;
                buttonConnect.Text = "Connected";
                buttonSend.Enabled = true;
                textMessageToSend.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                string encriptedOut = "";

                foreach(char c in textMessageToSend.Text)
                {
                    Char encripted = (char)(c + EncriptionKey.Value);

                    encriptedOut += encripted.ToString();
                }

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];


                msg = enc.GetBytes(encriptedOut);

                sck.Send(msg);
                listRecieved.Items.Add("You: " + textMessageToSend.Text);
                listRecieved.SelectedIndex = listRecieved.Items.Count - 1;
                listRecieved.SelectedIndex = -1;


                textMessageToSend.Clear();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listRecieved.Items.Clear();
        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                buttonSend.PerformClick();
            }
        }

    }
}
