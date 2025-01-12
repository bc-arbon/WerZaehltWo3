using System;
using System.IO.Compression;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Threading;
using System.IO;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class TtvListener
    {
        private CancellationTokenSource cancellationToken;
        private string debugFileDestinationDirectory;
        private Tournament tournament;

        public event EventHandler ServiceStarted;
        public event EventHandler ServiceStopped;
        public event EventHandler<(string, Exception)> ServiceError;
        public event EventHandler<TournamentTvUpdateEventArgs> Update;

        public bool IsListening
        {
            get
            {
                return (cancellationToken != null) && !cancellationToken.IsCancellationRequested;
            }
        }
        public TtvListener(string debugDirectory = null)
        {
            debugFileDestinationDirectory = debugDirectory;
            if ((debugFileDestinationDirectory != null) && !debugFileDestinationDirectory.EndsWith("\\"))
            {
                debugFileDestinationDirectory += "\\";
            }
        }
        public void Start()
        {
            if (cancellationToken != null)
            {
                throw new Exception("Listener already running");
            }

            cancellationToken = new CancellationTokenSource();
            Run();
        }

        public void Stop()
        {
            if (cancellationToken != null)
            {
                cancellationToken.Cancel();
            }
        }

        private void Run()
        {
            Task.Run(() =>
            {
                ServiceStarted?.Invoke(this, EventArgs.Empty);
                TcpListener tcp = new TcpListener(IPAddress.Loopback, 13333);
                tcp.Start();
                bool runSignal = true;
                while (runSignal)
                {
                    try
                    {
                        tcp.AcceptTcpClientAsync().ContinueWith(r =>
                        {
                            if (r.IsCompleted)
                            {
                                HandleConnection(r.Result);
                            }
                        }, cancellationToken.Token).Wait();
                    }
                    catch (AggregateException e)
                    {
                        e.Handle(innerException =>
                        {
                            if (innerException is TaskCanceledException)
                            {
                                tcp.Stop();
                                OnServiceStop();
                                runSignal = false;
                            }
                            else
                            {
                                OnServiceError(innerException);
                            }

                            return true;
                        });
                    }
                    catch (Exception e)
                    {
                        OnServiceError(e);
                    }
                }
            });
        }

        private void HandleConnection(TcpClient connection)
        {
            var connectionStream = connection.GetStream();
            connectionStream.Read(new byte[4], 0, 4);
            using (var unzip = new GZipStream(connectionStream, CompressionMode.Decompress))
            {
                var plainXml = new StreamReader(unzip, Encoding.UTF8).ReadToEnd();
                
                if (Directory.Exists(debugFileDestinationDirectory))
                {
                    string debugFile = string.Format("{1}{0}.xml", DateTime.Now.ToString().Replace(':', '-'), debugFileDestinationDirectory);
                    File.WriteAllText(debugFile, plainXml);
                }

                var doc = new XmlDocument();
                doc.LoadXml(plainXml);
                var rootNode = doc.SelectSingleNode("TOURNAMENT2024");
                this.tournament = new Tournament(rootNode);
                this.Update?.Invoke(this, new TournamentTvUpdateEventArgs(this.tournament));
            }
        }

        //private List<CourtData> ReadOnCourt(XmlReader reader)
        //{
        //    // Read from XML
        //    List<string> courtsWithMatchesAssigned = new List<string>();
        //    List<CourtData> onCourts = new List<CourtData>();
        //    while (reader.ReadToFollowing("MATCH"))
        //    {
        //        onCourts.Add(new CourtData(reader));
        //    }

        //    // Find courts with new matches
        //    List<CourtData> sendUpdates = new List<CourtData>();
        //    foreach (CourtData court in onCourts)
        //    {
        //        if (court.TpMatchID == 0) continue;
        //        lock (m_activeCourts)
        //        {
        //            CourtData activeCourt = m_activeCourts.FirstOrDefault(ac => ac.Name == court.Name);
        //            if (activeCourt == null)
        //            {
        //                // Court was previously unassigned, but now has a match
        //                m_activeCourts.Add(court);
        //                sendUpdates.Add(court);
        //            }
        //            else if (activeCourt?.TpMatchID != court.TpMatchID)
        //            {
        //                // Court has got a new match
        //                activeCourt.TpMatchID = court.TpMatchID;
        //                sendUpdates.Add(court);
        //            }
        //        }

        //        courtsWithMatchesAssigned.Add(court.Name);
        //    }

        //    // Find previously assigned but now empty courts
        //    lock (m_activeCourts)
        //    {
        //        sendUpdates.AddRange(
        //          m_activeCourts.FindAll(activeCourt => !courtsWithMatchesAssigned.Contains(activeCourt.Name)).Select(activeCourt =>
        //          {
        //              activeCourt.TpMatchID = 0;
        //              return activeCourt;
        //          })
        //        );
        //        m_activeCourts.RemoveAll(activeCourt => !courtsWithMatchesAssigned.Contains(activeCourt.Name));
        //    }

        //    return sendUpdates;
        //}        

        private void OnServiceError(Exception error, string message = "An error occured while listening for TP changes")
        {
            ServiceError?.Invoke(this, (message, error));
        }

        private void OnServiceStop()
        {
            cancellationToken = null;
            ServiceStopped?.Invoke(this, EventArgs.Empty);
        }
    }
}