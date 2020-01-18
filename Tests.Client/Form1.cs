namespace Tests.Client
{
    using BCA.WerZaehltWo3.ObjectModel;
    using System;
    using System.Net.Sockets;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        const int PORT_NO = 9320;
        const string SERVER_IP = "127.0.0.1";

        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //---data to send to the server---
            var textToSend = new TsRequest(Functions.GetPlayers, "aaa").ToString();

            //---create a TCPClient object at the IP and port no.---
            var client = new TcpClient(SERVER_IP, PORT_NO);
            var nwStream = client.GetStream();
            var bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            Console.WriteLine("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            var bytesToRead = new byte[client.ReceiveBufferSize];
            var bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            Console.ReadLine();
            client.Close();
        }
    }
}