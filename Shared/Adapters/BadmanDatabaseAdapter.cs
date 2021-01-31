using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Shared.Adapters
{
    public class BadmanDatabaseAdapter
    {
        private OleDbConnection connection;

        private static readonly string badmanConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Badman.mdb";

        public void Connect(string databaseFilepath)
        {
            if (databaseFilepath != Path.Combine(Application.StartupPath, "Badman.mdb"))
            {
                File.Copy(databaseFilepath, Path.Combine(Application.StartupPath, "Badman.mdb"), true);
            }

            this.connection = new OleDbConnection(badmanConnectionString);
            this.connection.Open();
        }

        public void Close()
        {
            if (this.connection.State == ConnectionState.Open)
            {
                this.connection.Close();
            }
        }

        public List<string> GetTournaments()
        {
            var com = new OleDbCommand("SELECT Name FROM Tournament", this.connection);
            var reader = com.ExecuteReader();

            if (reader != null)
            {
                var tournaments = new List<string>();
                while (reader.Read())
                {
                    tournaments.Add(reader["Name"].ToString());
                }

                return tournaments;
            }

            return new List<string>();
        }

        public List<string> GetPlayers(string tournament)
        {
            try
            {
                var com = new OleDbCommand("SELECT * FROM Q_Participants_Single WHERE Tournament.Name LIKE '" + tournament + "'", this.connection);
                var reader = com.ExecuteReader();

                if (reader != null)
                {
                    var players = new List<string>();
                    while (reader.Read())
                    {
                        //var player = new Player
                        //{
                        //    Name = reader["FirstName"] + " " + reader["LastName"],
                        //    Category = reader["Categories.Name"].ToString(),
                        //    Id = reader["LicenseNr"].ToString(),
                        //    Club = this.GetClubnameFromPlayer(reader["LicenseNr"].ToString())
                        //};
                        players.Add(reader["FirstName"] + " " + reader["LastName"]);
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

        private string GetClubnameFromPlayer(string licenseNr)
        {
            var com = new OleDbCommand("SELECT Clubs.Name FROM ((Players INNER JOIN Clubs ON Players.ClubID = Clubs.ID) INNER JOIN Q_Participants_Single ON Players.LicenseNr = Q_Participants_Single.LicenseNr) WHERE        (Players.LicenseNr = '" + licenseNr + "')", this.connection);
            var result = com.ExecuteScalar();
            return result != null ? result.ToString() : string.Empty;
        }
    }
}

////SELECT        Games.ID, Games.GameNr, Games.PlayTime, Games.Result, Games.IsDelayed, Games.GroupID, Games.GrpPosParticipant1, Games.GrpPosParticipant2, 
////                         Games.WinnerID, Games.Duration, Games.ResultNotCatched, Games.FinishedAt, Games.CallDoesNotStart, Games.GamePrinted, 
////                         Games.ResultDescriptor
////FROM            (((((DrawGroups INNER JOIN
////                         Draws ON DrawGroups.DrawID = Draws.ID) INNER JOIN
////                         Games ON DrawGroups.ID = Games.GroupID) INNER JOIN
////                         Disciplines ON Draws.DisciplineID = Disciplines.ID) INNER JOIN
////                         Categories ON Disciplines.CategoryID = Categories.ID) INNER JOIN
////                         Tournament ON Categories.TournamentID = Tournament.ID)
////WHERE        (Tournament.ID = 8)