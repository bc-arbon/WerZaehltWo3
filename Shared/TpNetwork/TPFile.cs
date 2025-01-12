using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Threading.Tasks;
using BCA.WerZaehltWo3.Shared.TPNetwork.Data;

namespace BCA.WerZaehltWo3.Shared.TPNetwork
{
    public class TPFile
    {
        public OdbcConnection Connection { get; private set; }
        private object connectionLock = new object();

        public TPFile(string filename)
        {
            string password = "d4R2GY76w2qzZ";
            OdbcConnectionStringBuilder connectionStringBuilder = new OdbcConnectionStringBuilder();
            connectionStringBuilder.Driver = "Microsoft Access Driver (*.mdb, *.accdb)";
            connectionStringBuilder.Add("Dbq", filename);
            connectionStringBuilder.Add("Uid", "Admin");
            connectionStringBuilder.Add("Pwd", password);
            lock (connectionLock)
            {
                Connection = new OdbcConnection(connectionStringBuilder.ConnectionString);
                Connection.Open();
            }
        }

        public void Close()
        {
            lock (connectionLock)
            {
                if ((Connection != null) && (Connection.State == System.Data.ConnectionState.Open))
                {
                    Connection.Close();
                }
            }
        }
        private Task<List<T>> LoadStuff<T>(string sql, Func<IDataReader, T> parseDbData)
        {
            lock (connectionLock)
            {
                if (Connection?.State != ConnectionState.Open)
                {
                    throw new Exception("Could not read file; connection closed");
                }
            }

            return Task.Run(() =>
            {
                List<T> result = new List<T>();
                lock (connectionLock)
                {
                    using (IDbCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                T item = parseDbData(reader);
                                result.Add(item);
                            }
                        }
                    }
                }

                return result;
            });
        }

        public async Task<List<TournamentInformation>> LoadTournamentInformation()
        {
            return await LoadStuff("SELECT * FROM TournamentInformation", reader => new TournamentInformation(reader));
        }

        public async Task<List<LinkData>> LoadLinks()
        {
            return await LoadStuff("SELECT * FROM Link", reader => new LinkData(reader));
        }

        public async Task<List<LocationData>> LoadLocations()
        {
            return await LoadStuff("SELECT * FROM Location", reader => new LocationData(reader));
        }

        public async Task<List<CourtData>> LoadCourts()
        {
            return await LoadStuff("SELECT * FROM Court", reader => new CourtData(reader));
        }

        public async Task<List<EventData>> LoadEvents()
        {
            return await LoadStuff("SELECT * FROM Event", reader => new EventData(reader));
        }

        public async Task<List<DrawData>> LoadDraws()
        {
            return await LoadStuff("SELECT * FROM Draw", reader => new DrawData(reader));
        }

        public async Task<List<EntryData>> LoadEntries()
        {
            return await LoadStuff("SELECT * FROM Entry", reader => new EntryData(reader));
        }

        public async Task<List<PlayerData>> LoadPlayers()
        {
            return await LoadStuff("SELECT * FROM Player", (reader) => new PlayerData(reader));
        }

        public async Task<List<ClubData>> LoadClubs()
        {
            return await LoadStuff("SELECT * FROM Club", reader => new ClubData(reader));
        }

        public async Task<List<PlayerMatchData>> LoadPlayerMatches()
        {
            return await LoadStuff("SELECT * FROM PlayerMatch", reader => new PlayerMatchData(reader));
        }
    }
}