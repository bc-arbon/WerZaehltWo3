namespace BCA.WerZaehltWo3.Adapters
{
    using BCA.WerZaehltWo3.ObjectModel;
    using BCA.WerZaehltWo3.ObjectModel.TournamentSoftware;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.Windows.Forms;

    public class TsDatabaseAdapter
    {
        private OleDbConnection connection;

        private readonly string tsConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ts.tp;Jet OLEDB:Database Password=d4R2GY76w2qzZ;";

        public void Connect(string databaseFilepath)
        {
            if (databaseFilepath != Path.Combine(Application.StartupPath, "ts.tp"))
            {
                File.Copy(databaseFilepath, Path.Combine(Application.StartupPath, "ts.tp"), true);
            }

            this.connection = new OleDbConnection(this.tsConnectionString);
            this.connection.Open();
        }

        public void Close()
        {
            if (this.connection != null && this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }

        public List<Player> GetPlayers()
        {
            try
            {
                var com = new OleDbCommand("SELECT Player.firstname, Player.name, Club.name, Player.memberid FROM Club INNER JOIN Player ON Club.id = Player.club", this.connection);
                var reader = com.ExecuteReader();

                if (reader != null)
                {
                    var players = new List<Player>();
                    while (reader.Read())
                    {
                        var player = new Player
                        {
                            Name = reader["firstname"] + " " + reader["Player.name"],
                            //Category = reader["Categories.Name"].ToString(),
                            Id = reader["memberid"].ToString(),
                            Club = reader["Club.name"].ToString()
                        };
                        players.Add(player);
                    }

                    return players;
                }
            }
            finally
            {
                this.connection.Close();
            }

            return new List<Player>();
        }

        public List<Event> GetEvents()
        {
            try
            {
                var com = new OleDbCommand("SELECT id, name FROM Event", this.connection);
                var reader = com.ExecuteReader();

                if (reader != null)
                {
                    var events = new List<Event>();
                    while (reader.Read())
                    {
                        var ev = new Event
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString()
                        };
                        events.Add(ev);
                    }

                    return events;
                }
            }
            finally
            {
                this.connection.Close();
            }

            return new List<Event>();
        }

        public List<Entry> GetEntries(int eventId)
        {
            try
            {
                // TODO Get player names first

                var com2 = new OleDbCommand("SELECT id, player1, player2 FROM Entry WHERE event = '@eventid'", this.connection);
                com2.Parameters.AddWithValue("eventId", eventId);

                var reader2 = com2.ExecuteReader();

                if (reader2 != null)
                {
                    var events = new List<Entry>();
                    while (reader2.Read())
                    {
                        var ev = new Entry
                        {
                            Id = Convert.ToInt32(reader2["id"]),
                            Player1Id = Convert.ToInt32(reader2["player1"]),
                            Player2Id = Convert.ToInt32(reader2["player2"])
                        };
                        events.Add(ev);
                    }
                }

                // TODO resolve player names by ids

                // TODO get planning id from PlayerMatch table
            }
            finally
            {
                this.connection.Close();
            }

            return new List<Entry>();
        }
    }
}