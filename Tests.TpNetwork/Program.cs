using BCA.WerZaehltWo3.Shared.TournamentTv;
using BCA.WerZaehltWo3.Shared.TPNetwork;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tests.TpNetwork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tpstream = new TPStream("192.168.10.146", "asdf");
            var bla = tpstream.Login().Result;

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
    }
}