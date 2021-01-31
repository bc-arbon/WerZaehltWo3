using BCA.WerZaehltWo3.Shared.ObjectModel;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace BCA.WerZaehltWo3.Tests.Server.Adapters
{
    public class TsDatabaseAdapter : IAdapter
    {
        private OleDbConnection connection;

        private readonly string tsConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=$path$;Jet OLEDB:Database Password=d4R2GY76w2qzZ;";

        public void Connect(string databaseFilepath)
        {
            var path = this.tsConnectionString.Replace("$path$", databaseFilepath);

            this.connection = new OleDbConnection(path);
            this.connection.Open();
        }

        public void Close()
        {
            if (this.connection != null && this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }

        public List<string> GetPlayers()
        {
            try
            {
                var com = new OleDbCommand("SELECT Player.firstname, Player.name, Club.name, Player.memberid FROM Club INNER JOIN Player ON Club.id = Player.club", this.connection);
                var reader = com.ExecuteReader();

                if (reader != null)
                {
                    var players = new List<string>();
                    while (reader.Read())
                    {
                        //var player = new Player
                        //{
                        //    Name = reader["firstname"] + " " + reader["Player.name"],
                        //    //Category = reader["Categories.Name"].ToString(),
                        //    Id = reader["memberid"].ToString(),
                        //    Club = reader["Club.name"].ToString()
                        //};
                        players.Add(reader["firstname"] + " " + reader["Player.name"]);
                    }

                    return players;
                }
            }
            finally
            {
                this.connection.Close();
            }

            return new List<string>();
        }
    }
}