using System;
using System.Net.Sockets;
using System.Net;

namespace Tests.TcpTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                Console.WriteLine("Starting TCP listener...");
                var listener = new TcpListener(ipAddress, 13333);
                listener.Start();

                while (true)
                {
                    Console.WriteLine("Server is listening on " + listener.LocalEndpoint);
                    Console.WriteLine("Waiting for a connection...");
                    Socket client = listener.AcceptSocket();
                    Console.WriteLine("Connection accepted.");
                    Console.WriteLine("Reading data...");
                    byte[] data = new byte[100];
                    int size = client.Receive(data);
                    Console.WriteLine("Recieved data: ");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(Convert.ToChar(data[i]));
                    }

                    Console.WriteLine();
                    client.Close();
                }

                listener.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
