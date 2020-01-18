namespace BCA.WerZaehltWo3.Adapters
{
    using BCA.WerZaehltWo3.ObjectModel;
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
    }
}