using BCA.WerZaehltWo3.Tests.Server.Adapters;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using BCA.WerZaehltWo3.Tests.Server.Adapters.Adapters;
using BCA.WerZaehltWo3.Shared;
using BCA.WerZaehltWo3.Shared.Helpers;

namespace BCA.WerZaehltWo3.Tests.Server
{
    public static class Program
    {
        private static IAdapter adapter;
        private static ServerSettings settings;
        public static void Main()
        {
            //---initialize settings
            settings = new SettingsProvider().Settings;

            //---initialize adapter ---
            switch(settings.Adapter)
            {
                case "ts":
                    adapter = new TsDatabaseAdapter();
                    break;
                case "test":
                    adapter = new TestAdapter();
                    break;
            }            

            //---listen at the specified IP and port no.---
            var localAdd = IPAddress.Parse(settings.ServerAddress);
            var listener = new TcpListener(localAdd, settings.Port);
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

                var result = HandleReceivedData(dataReceived);

                //---write back the text to the client---
                Console.Write("Sending back : " + result);
                var bytesToSend = ASCIIEncoding.ASCII.GetBytes(result);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                client.Close();
            }
        }

        private static string HandleReceivedData(string dataReceived)
        {
            var split = dataReceived.Split(';');
            var function = (Functions)Convert.ToInt32(split[0]);
            Console.WriteLine("Processing " + function.ToString() + "...");
            var result = string.Empty;
            switch (function)
            {
                case Functions.GetPlayers:
                    result = GetPlayers();
                    break;
            }

            return result;
        }

        private static string GetPlayers()
        {            
            adapter.Connect(settings.DatabaseFilepath);
            var players = adapter.GetPlayers();
            adapter.Close();
            var result = "<Players>";
            foreach (var player in players)
            {
                result += JsonHelper.Save(player);
            }
            result += "</Players>";

            return result;
        }
    }
}
