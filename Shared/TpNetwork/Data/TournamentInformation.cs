﻿using System.Data;

namespace BCA.WerZaehltWo3.Shared.TPNetwork.Data
{
    public class TournamentInformation : TpDataObject
    {
        public int ID { get; set; }
        public string TournamentID { get; set; }
        public string TournamentName { get; set; }

        public TournamentInformation() { }

        public TournamentInformation(IDataReader reader)
        {
            ID = GetInt(reader, "id");
            TournamentID = GetString(reader, "tournamentid");
            TournamentName = GetString(reader, "tournamentname");
        }
    }
}