using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO.Compression;
using System.IO;
using System.Xml;

namespace Tests.TpNetwork
{
    public class TPStream
    {
        public string Password { get; set; }
        public IPAddress IP { get; set; } = IPAddress.Loopback;

        public event EventHandler<(string, Exception)> Error;

        public TPStream(string ip, string password)
        {
            IP = IPAddress.Parse(ip);
            Password = password;
        }

        public async Task<string> Login()
        {
            TcpClient tcp = new TcpClient();
            await tcp.ConnectAsync(IP, 9901);

            var loginRequest = new LoginRequest()
            {
                Password = Password,
                IP = IP
            };

            StringBuilder sb = new StringBuilder();
            using (StringWriter ss = new StringWriter(sb))
            using (var xmlWriter = XmlWriter.Create(ss))
            {
                loginRequest.CreateDocument().WriteContentTo(xmlWriter);
            }

            Console.WriteLine(sb.ToString());

            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory, CompressionMode.Compress))
                {
                    // This shit doesn't work.
                    // Request is sent out, but no response is coming back

                    using (XmlWriter xmlWriter = XmlWriter.Create(gzip))
                    {
                        loginRequest.CreateDocument().WriteContentTo(xmlWriter);
                        xmlWriter.Flush();

                        using (NetworkStream network = tcp.GetStream())
                        {
                            network.Write(new byte[4] { 0x0, 0x0, 0x0, Convert.ToByte(memory.Length) }, 0, 4);
                            network.Write(memory.ToArray(), 0, (int)memory.Length);

                            network.Read(new byte[4], 0, 4);
                            using (GZipStream gzip2 = new GZipStream(network, CompressionMode.Decompress))
                            using (XmlReader reader = XmlReader.Create(gzip2))
                            {
                                string xml = reader.ReadOuterXml();
                                return xml;
                            }
                        }
                    }
                }
            }
        }

        public async Task<string> GetTournamentInfo()
        {
            TcpClient tcp = new TcpClient();
            await tcp.ConnectAsync(IP, 9901);

            var stir = new SendTournamentInfoRequest()
            {
                Password = Password,
                IP = IP
            };

            StringBuilder sb = new StringBuilder();
            using (StringWriter ss = new StringWriter(sb))
            using (var xmlWriter = XmlWriter.Create(ss))
            {
                stir.CreateDocument().WriteContentTo(xmlWriter);
            }

            Console.WriteLine(sb.ToString());

            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory, CompressionMode.Compress))
                using (XmlWriter xmlWriter = XmlWriter.Create(gzip))
                {
                    stir.CreateDocument().WriteContentTo(xmlWriter);
                }

                using (NetworkStream network = tcp.GetStream())
                {
                    network.Write(new byte[4] { 0x0, 0x0, 0x1, 0x6 }, 0, 4);
                    network.Write(memory.ToArray(), 3, 1500);

                    network.Read(new byte[4], 0, 4);
                    using (GZipStream gzip = new GZipStream(network, CompressionMode.Decompress))
                    using (XmlReader reader = XmlReader.Create(gzip))
                    {
                        return reader.ReadOuterXml();
                    }
                }
            }
        }

        /*
        public void Start() {
          m_doCancel = new CancellationTokenSource();
          Task.Run(() => {
            ServiceStarted?.Invoke(this, EventArgs.Empty);
            TcpListener tcp = new TcpListener(IPAddress.Any, 13333);
            tcp.Start();
            bool doBreak = false;
            while (!doBreak) {
              try {
                tcp.AcceptTcpClientAsync().ContinueWith(r => {
                  if (r.IsCompleted) {
                    HandleConnection(r.Result);
                  }
                }, m_doCancel.Token).Wait();
              } catch (AggregateException e) {
                e.Handle(innerException => {
                  if (innerException is TaskCanceledException) {
                    tcp.Stop();
                    doBreak = true;
                  } else {
                    OnServiceError(innerException);
                  }
                  return true;
                });
              } catch (Exception e) {
                OnServiceError(e);
              }
            }
            ServiceStopped?.Invoke(this, EventArgs.Empty);
          });
        }

        protected void HandleConnection(TcpClient connection) {
          var connectionStream = connection.GetStream();
          connectionStream.Read(new byte[4], 0, 4);
          using (var unzip = new GZipStream(connectionStream, CompressionMode.Decompress))
          {
            XmlReaderSettings xmlSettings = new XmlReaderSettings() {
              Async = true
            };
            using (XmlReader xmlReader = XmlReader.Create(unzip, xmlSettings)) {
              xmlReader.ReadToFollowing("ONCOURT");
              using (XmlReader onCourt = xmlReader.ReadSubtree()) {
                ReadOnCourt(onCourt);
              }
            }
          }
        }

        protected void ReadOnCourt(XmlReader reader) {
          List<string> courtsWithMatchesAssigned = new List<string>();
          while (reader.ReadToFollowing("MATCH")) {
            int.TryParse(reader.GetAttribute("ID"), out int tpMatchId);
            if (tpMatchId == 0) continue;

            string tpCourtName = reader.GetAttribute("CT");

            m_activeCourts.TryGetValue(tpCourtName, out int currentMatchId);
            if ((currentMatchId == 0) || (currentMatchId != tpMatchId)) {
              m_activeCourts[tpCourtName] = tpMatchId;
              CourtUpdate?.Invoke(this, (tpCourtName, tpMatchId));
            }
            courtsWithMatchesAssigned.Add(tpCourtName);      
          }
          foreach (string nowEmptyCourt in m_activeCourts.Select(kvp => kvp.Key).Except(courtsWithMatchesAssigned)) {
            CourtUpdate?.Invoke(this, (nowEmptyCourt, 0));
          }
        }

        */

        protected void OnError(Exception error)
        {
            Error?.Invoke(this, ("An error occured while listening for TP changes", error));
        }
    }
}
