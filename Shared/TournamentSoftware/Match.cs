﻿using System;

namespace BCA.WerZaehltWo3.Shared.TournamentSoftware
{
    public class Match
    {
        public long Id { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Team Winner { get; set; }
        public string Set1 { get; set; }
        public string Set2 { get; set; }
        public string Set3 { get; set; }
        public bool WalkoverTeam1 { get; set; }
        public bool WalkoverTeam2 { get; set; }
        public int Matchnr { get; set; }
        public int Roundnr { get; set; }
        public Draw Draw { get; set; }
        public int Court { get; set; }
        public DateTime PlanDate { get; set; }
        public int Order { get; set; }
        public string OrderSorting { get; set; }

        public override string ToString()
        {
            return this.Id + "," + this.OrderSorting + "," + this.Team1 + "-" + this.Team2 + "," + this.Draw;
        }
    }
}
