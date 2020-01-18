namespace Tests.Server
{
    using BCA.WerZaehltWo3.ObjectModel;
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;

    public class Program
    {
        const int PORT_NO = 9320;
        const string SERVER_IP = "127.0.0.1";

        public static void Main(string[] args)
        {
            //---listen at the specified IP and port no.---
            var localAdd = IPAddress.Parse(SERVER_IP);
            var listener = new TcpListener(localAdd, PORT_NO);
            Console.WriteLine("Listening...");
            listener.Start();
            while (true)
            {
                //---incoming client connected---
                var client = listener.AcceptTcpClient();

                //---get the incoming data through a network stream---
                var nwStream = client.GetStream();
                var buffer = new byte[client.ReceiveBufferSize];

                //---read incoming stream---
                var bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                //---convert the data received into a string---
                var dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received : " + dataReceived);

                var result = handleReceivedData(dataReceived);

                //---write back the text to the client---
                Console.WriteLine("Sending back : " + result);
                var bytesToSend = ASCIIEncoding.ASCII.GetBytes(result);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                client.Close();
            }
        }

        private static string handleReceivedData(string dataReceived)
        {
            var split = dataReceived.Split(';');
            var function = (Functions)Convert.ToInt32(split[0]);
            Console.WriteLine(function.ToString());
            return split[1] + " bla";
        }
    }
}
