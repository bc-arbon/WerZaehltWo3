using BCA.WerZaehltWo3.Shared.TpNetwork;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Tests.TpNetwork.Logic;

namespace Tests.TpNetwork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var response = VisualXmlResponse.Parse(File.ReadAllText("C:\\repos\\bc-arbon\\WerZaehltWo3\\SampleData\\tournamentinforesponse.xml"));
            Console.WriteLine(response);
            // ---------------

            //using var client = new TcpClient();

            //client.ConnectAsync("192.168.10.146", 9901).Wait();

            //using NetworkStream stream = client.GetStream();

            //var loginRequest = new LoginRequest()
            //{
            //    Password = "1234",
            //    IP = IPAddress.Parse("192.168.10.146")
            //};

            //StringBuilder sb = new StringBuilder();
            //using (StringWriter ss = new StringWriter(sb))
            //using (var xmlWriter = XmlWriter.Create(ss))
            //{
            //    loginRequest.CreateDocument().WriteContentTo(xmlWriter);
            //}

            //var loginRequestXml = sb.ToString();

            //TpNetworkConnector.SendCompressedXmlAsync(stream, loginRequestXml).Wait();

            //var loginResponseXml = TpNetworkConnector.ReadCompressedXmlAsync(stream).Result;
            
            //Console.WriteLine(loginResponseXml);

            // ---------------

            //var tpstream = new TPStream("192.168.10.146", "1234");
            //var bla = tpstream.Login().Result;

            // ---------------

            //var xml = File.ReadAllText("TournamentTvResponse.xml");
            //var doc = new XmlDocument();
            //doc.LoadXml(xml);
            //var rootNode = doc.SelectSingleNode("TOURNAMENT2024");

            //var tournament = new Tournament(rootNode);

            // -------------

            //var listener = new TtvListener(Path.GetDirectoryName(Environment.ProcessPath));
            //listener.ServiceStarted += (sender, e) => Console.WriteLine("Listener started");
            //listener.ServiceError += (sender, e) => Console.WriteLine(e.Item2.Message);
            //listener.ServiceStopped += (sender, e) => Console.WriteLine("Listener stopped");
            ////listener.CourtUpdate += (sender, e) => Console.WriteLine("Court '{0}' updated with match {1}", e.CourtName, e.Match);
            //listener.Start();
            //Console.WriteLine("Press any key to stop");
            //Console.ReadKey();
            //listener.Stop();
        }

        private static async Task TpNetworkConnectorSendCompressedXmlAsync(NetworkStream stream, object requestXml)
        {
            throw new NotImplementedException();
        }
    }
}