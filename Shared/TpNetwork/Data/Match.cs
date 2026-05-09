using BCA.WerZaehltWo3.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Match
    {
        public Match()
        {
            this.Sets = new List<Set>();
        }

        public int ID { get; set; }
        public int DrawID { get; set; }
        public int PlanningID { get; set; }
        public int From1 { get; set; }
        public int From2 { get; set; }
        public int Winner { get; set; }
        public bool IsMatch { get; set; }
        public bool IsPlayable { get; set; }
        public int DisplayOrder { get; set; }
        public int Round { get; set; }
        public int MatchNr { get; set; }
        public string RoundName { get; set; }
        public bool ScoreSheetPrinted { get; set; }
        public int Duration { get; set; }
        public int Shuttles { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public int Highlight { get; set; }
        public DateTime StartTime { get; set; }
        public int Official1ID { get; set; }
        public List<Set> Sets { get; set; }
        public int ScoreStatus { get; set; }
        public int MatchesPlayed { get; set; }
        public int MatchPoints { get; set; }
        public int MatchesWon { get; set; }
        public int MatchesLost { get; set; }
        public int SetsFor { get; set; }
        public int SetsAgainst { get; set; }
        public int SetSaldo { get; set; }
        public double SetRatio { get; set; }
        public double SetPercentage { get; set; }
        public int GamesFor { get; set; }
        public int GamesAgainst { get; set; }
        public int GameSaldo { get; set; }
        public double GameRatio { get; set; }
        public double GamePercentage { get; set; }

        public DateTime PlannedTime { get; set; }
        public int CourtID { get; set; }

        public static Match Parse(XmlNode node)
        {
            var match = new Match();
            match.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            match.DrawID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='DrawID']").InnerText);
            match.PlanningID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='PlanningID']").InnerText);
            match.From1 = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='From1']")?.InnerText);
            match.From2 = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='From2']")?.InnerText);
            match.Winner = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Winner']")?.InnerText);
            match.IsMatch = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='IsMatch']")?.InnerText);
            match.IsPlayable = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='IsPlayable']")?.InnerText);
            match.DisplayOrder = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='DisplayOrder']").InnerText);
            match.Round = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Round']").InnerText);
            match.MatchNr = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MatchNr']").InnerText);
            match.RoundName = node.SelectSingleNode("ITEM[@ID='RoundName']")?.InnerText;
            match.ScoreSheetPrinted = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='ScoreSheetPrinted']").InnerText);
            match.Duration = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Duration']").InnerText);
            match.Shuttles = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Shuttles']").InnerText);
            match.Status = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Status']").InnerText);
            match.Note = node.SelectSingleNode("ITEM[@ID='Note']")?.InnerText;
            match.Highlight = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Highlight']").InnerText);
            match.StartTime = VisualXmlHelpers.GetDateTime(node.SelectSingleNode("ITEM[@ID='StartTime']/DATETIME"));
            match.Official1ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Official1ID']")?.InnerText);

            var setNodes = node.SelectNodes("GROUP[@ID='Sets']/GROUP[@ID='Set']");
            foreach (XmlNode setNode in setNodes)
            {
                match.Sets.Add(Set.Parse(setNode));
            }

            match.ScoreStatus = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ScoreStatus']").InnerText);
            match.MatchesPlayed = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MatchesPlayed']")?.InnerText);
            match.MatchPoints = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MatchPoints']")?.InnerText);
            match.MatchesWon = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MatchesWon']")?.InnerText);
            match.MatchesLost = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MatchesLost']")?.InnerText);
            match.SetsFor = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='SetsFor']")?.InnerText);
            match.SetsAgainst = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='SetsAgainst']")?.InnerText);
            match.SetSaldo = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='SetSaldo']")?.InnerText);
            match.SetRatio = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='SetRatio']")?.InnerText);
            match.SetPercentage = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='SetPercentage']")?.InnerText);
            match.GamesFor = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='GamesFor']")?.InnerText);
            match.GamesAgainst = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='GamesAgainst']")?.InnerText);
            match.GameSaldo = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='GameSaldo']")?.InnerText);
            match.GameRatio = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='GameRatio']")?.InnerText);
            match.GamePercentage = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='GamePercentage']")?.InnerText);
            match.PlannedTime = VisualXmlHelpers.GetDateTime(node.SelectSingleNode("ITEM[@ID='PlannedTime']/DATETIME"));
            match.CourtID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='CourtID']")?.InnerText);
            return match;
        }
    }
}
