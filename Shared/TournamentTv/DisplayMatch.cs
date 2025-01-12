using System;
using System.Collections.Generic;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class DisplayMatch : TtvDataObject
    {
        public int MatchId { get; set; }
        public string EventName { get; set; }
        public int EventId { get; set; }
        public string Round { get; set; }
        public string Dunknown { get; set; }
        public string Court { get; set; }
        public string LastName1 { get; set; }
        public string FirstName1 { get; set; }
        public string M1unknown { get; set; }
        public string A1unknown { get; set; }
        public string PlayerId1 { get; set; }
        public string LastName2 { get; set; }
        public string FirstName2 { get; set; }
        public string M2unknown { get; set; }
        public string A2unknown { get; set; }
        public string PlayerId2 { get; set; }
        public string LastName3 { get; set; }
        public string FirstName3 { get; set; }
        public string M3unknown { get; set; }
        public string A3unknown { get; set; }
        public string PlayerId3 { get; set; }
        public string LastName4 { get; set; }
        public string FirstName4 { get; set; }
        public string M4unknown { get; set; }
        public string A4unknown { get; set; }
        public string PlayerId4 { get; set; }
        public string Country1 { get; set; }
        public string Country2 { get; set; }
        public string Country3 { get; set; }
        public string Country4 { get; set; }
        public string Seed1 { get; set; }
        public string Seed2 { get; set; }
        public DateTime ScheduledTime { get; set; }
        public string Wunknown { get; set; }
        public string Sunknown { get; set; }
        public List<DisplayMatchSet> Sets { get; set; } = new List<DisplayMatchSet>();
        public Official Umpire { get; set; }
        public Official ServiceJudge { get; set; }

        public DisplayMatch(XmlNode node)
        {
            this.MatchId = GetInt(node, "ID");
            this.EventName = GetString(node, "E");
            this.EventId = GetInt(node, "EID");
            this.Round = GetString(node, "R");
            this.Dunknown = GetString(node, "D");
            this.Court = GetString(node, "CT");

            this.LastName1 = GetString(node, "N1");
            this.FirstName1 = GetString(node, "F1");
            this.M1unknown = GetString(node, "M1");
            this.A1unknown = GetString(node, "A1");
            this.PlayerId1 = GetString(node, "ID1");

            this.LastName2 = GetString(node, "N2");
            this.FirstName2 = GetString(node, "F2");
            this.M2unknown = GetString(node, "M2");
            this.A2unknown = GetString(node, "A2");
            this.PlayerId2 = GetString(node, "ID2");

            this.LastName3 = GetString(node, "N3");
            this.FirstName3 = GetString(node, "F3");
            this.M3unknown = GetString(node, "M3");
            this.A3unknown = GetString(node, "A3");
            this.PlayerId3 = GetString(node, "ID3");

            this.LastName4 = GetString(node, "N4");
            this.FirstName4 = GetString(node, "F4");
            this.M4unknown = GetString(node, "M4");
            this.A4unknown = GetString(node, "A4");
            this.PlayerId4 = GetString(node, "ID4");

            this.Country1 = GetString(node, "C1");
            this.Country2 = GetString(node, "C2");
            this.Country3 = GetString(node, "C3");
            this.Country4 = GetString(node, "C4");

            this.Seed1 = GetString(node, "S1");
            this.Seed1 = GetString(node, "S2");

            this.ScheduledTime = GetDateTime(node, "T");
            this.Wunknown = GetString(node, "W");
            this.Sunknown = GetString(node, "S");

            var setNodes = node.SelectNodes("SETS/SET");
            foreach (XmlNode setNode in setNodes)
            {
                this.Sets.Add(new DisplayMatchSet(setNode));
            }

            var officialNodes = node.SelectNodes("OFFICIALS/OFFICIAL");
            foreach (XmlNode officialNode in officialNodes)
            {
                var official = new Official(officialNode);
                if (official.Id == 1)
                {
                    this.Umpire = official;
                }

                if (official.Id == 2)
                {
                    this.ServiceJudge = official;
                }
            }
        }
    }
}