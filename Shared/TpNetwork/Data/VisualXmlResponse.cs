using BCA.WerZaehltWo3.Shared.TpNetwork.Data;
using System;
using System.Collections.Generic;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork
{
    public class VisualXmlResponse
    {
        public VisualXmlResponse()
        {
            this.Settings = new List<Setting>();
            this.TournamentDays = new List<TournamentDay>();
            this.ScoringFormats = new List<ScoringFormat>();
            this.Matches = new List<Match>();
            this.Events = new List<Event>();
            this.Stages = new List<Stage>();
            this.Districts = new List<District>();
            this.Clubs = new List<Club>();
            this.Locations = new List<Location>();
            this.Officials = new List<Official>();
            this.Draws = new List<Draw>();
            this.Courts = new List<Court>();
            this.Links = new List<Link>();
            this.Players = new List<Player>();
            this.Payments = new List<Payment>();
            this.Entries = new List<Entry>();
            this.StageEntries = new List<StageEntry>();
            this.MatchWarnings = new List<MatchWarning>();
        }

        public int VersionHi { get; set; }
        public int VersionLo { get; set; }

        public string ActionID { get; set; }
        public string Password { get; set; }
        public string Unicode { get; set; }
        public string Action { get; set; }
        public int Result { get; set; }

        public string ClientIp { get; set; }
        public string Xml { get; set; }

        public List<Setting> Settings { get; private set; }
        public List<TournamentDay> TournamentDays { get; private set; }
        public List<ScoringFormat> ScoringFormats { get; private set; }
        public List<Match> Matches { get; private set; }
        public List<Event> Events { get; private set; }
        public List<Stage> Stages { get; private set; }
        public List<District> Districts { get; private set; }
        public List<Club> Clubs { get; private set; }
        public List<Location> Locations { get; private set; }
        public List<Official> Officials { get; private set; }
        public List<Draw> Draws { get; private set; }
        public List<Court> Courts { get; private set; }
        public List<Link> Links { get; private set; }
        public List<Player> Players { get; private set; }
        public List<Payment> Payments { get; private set; }
        public List<Entry> Entries { get; private set; }
        public List<StageEntry> StageEntries { get; private set; }
        public List<MatchWarning> MatchWarnings { get; private set; }

        public static VisualXmlResponse Parse(string xml)
        {
            var response = new VisualXmlResponse();
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var versionNode = doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Header']/GROUP[@ID='Version']");
            response.VersionHi = Convert.ToInt32(versionNode.SelectSingleNode("ITEM[@ID='Hi']").InnerText);
            response.VersionLo = Convert.ToInt32(versionNode.SelectSingleNode("ITEM[@ID='Lo']").InnerText);

            var actionNode = doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Action']");
            response.ActionID = actionNode.SelectSingleNode("ITEM[@ID='ID']").InnerText;
            response.Password = actionNode.SelectSingleNode("ITEM[@ID='Password']").InnerText;
            response.Unicode = actionNode.SelectSingleNode("ITEM[@ID='Unicode']").InnerText;
            response.Action = actionNode.SelectSingleNode("ITEM[@ID='Action']").InnerText;
            response.Result = Convert.ToInt32(actionNode.SelectSingleNode("ITEM[@ID='Result']").InnerText);

            response.ClientIp = doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Client']/ITEM[@ID='IP']").InnerText;
            response.Xml = xml;

            var tournamentNode = doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Result']/GROUP[@ID='Tournament']");

            // Settings
            var settingNodes = tournamentNode.SelectNodes("GROUP[@ID='Settings']/GROUP[@ID='Setting']");
            foreach (XmlNode settingNode in settingNodes)
            {                
                response.Settings.Add(Setting.Parse(settingNode));
            }

            // TournamentDays
            var tournamentDayNodes = tournamentNode.SelectNodes("GROUP[@ID='TournamentDays']/GROUP[@ID='TournamentDay']");
            foreach (XmlNode tournamentDayNode in tournamentDayNodes)
            {                
                response.TournamentDays.Add(TournamentDay.Parse(tournamentDayNode));
            }

            // ScoringFormats
            var scoringFormatNodes = tournamentNode.SelectNodes("GROUP[@ID='ScoringFormats']/GROUP[@ID='ScoringFormat']");
            foreach (XmlNode scoringFormatNode in scoringFormatNodes)
            {
                response.ScoringFormats.Add(ScoringFormat.Parse(scoringFormatNode));
            }

            // Events
            var eventNodes = tournamentNode.SelectNodes("GROUP[@ID='Events']/GROUP[@ID='Event']");
            foreach (XmlNode eventNode in eventNodes)
            {
                response.Events.Add(Event.Parse(eventNode));
            }

            // Stages
            var stageNodes = tournamentNode.SelectNodes("GROUP[@ID='Stages']/GROUP[@ID='Stage']");
            foreach (XmlNode stageNode in stageNodes)
            {
                response.Stages.Add(Stage.Parse(stageNode));
            }

            // Districts
            var districtNodes = tournamentNode.SelectNodes("GROUP[@ID='Districts']/GROUP[@ID='District']");
            foreach (XmlNode districtNode in districtNodes)
            {
                response.Districts.Add(District.Parse(districtNode));
            }

            // Clubs
            var clubNodes = tournamentNode.SelectNodes("GROUP[@ID='Clubs']/GROUP[@ID='Club']");
            foreach (XmlNode clubNode in clubNodes)
            {
                response.Clubs.Add(Club.Parse(clubNode));
            }

            // Locations
            var locationNodes = tournamentNode.SelectNodes("GROUP[@ID='Locations']/GROUP[@ID='Location']"); 
            foreach (XmlNode locationNode in locationNodes)
            {
                response.Locations.Add(Location.Parse(locationNode));
            }

            // Officials
            var officialNodes = tournamentNode.SelectNodes("GROUP[@ID='Officials']/GROUP[@ID='Official']");
            foreach (XmlNode officialNode in  officialNodes)
            {
                response.Officials.Add(Official.Parse(officialNode));
            }

            // Draws
            var drawNodes = tournamentNode.SelectNodes("GROUP[@ID='Draws']/GROUP[@ID='Draw']");
            foreach (XmlNode drawNode in drawNodes)
            {
                response.Draws.Add(Draw.Parse(drawNode));
            }

            // Courts
            var courtNodes = tournamentNode.SelectNodes("GROUP[@ID='Courts']/GROUP[@ID='Court']");
            foreach (XmlNode courtNode in courtNodes)
            {
                response.Courts.Add(Court.Parse(courtNode));
            }

            // Links
            var linkNodes = tournamentNode.SelectNodes("GROUP[@ID='Links']/GROUP[@ID='Link']");
            foreach (XmlNode linkNode in linkNodes)
            {
                response.Links.Add(Link.Parse(linkNode));
            }

            // Players
            var playerNodes = tournamentNode.SelectNodes("GROUP[@ID='Players']/GROUP[@ID='Player']");
            foreach (XmlNode playerNode in playerNodes)
            {
                response.Players.Add(Player.Parse(playerNode));
            }

            // Payments
            var paymentNodes = tournamentNode.SelectNodes("GROUP[@ID='Payments']/GROUP[@ID='Payment']");
            foreach (XmlNode paymentNode in paymentNodes)
            {
                response.Payments.Add(Payment.Parse(paymentNode));
            }

            // Entries
            var entryNodes = tournamentNode.SelectNodes("GROUP[@ID='Entries']/GROUP[@ID='Entry']");
            foreach (XmlNode entryNode in entryNodes)
            {
                response.Entries.Add(Entry.Parse(entryNode));
            }

            // StageEntries
            var stageEntryNodes = tournamentNode.SelectNodes("GROUP[@ID='StageEntries']/GROUP[@ID='StageEntry']");
            foreach (XmlNode stageEntryNode in stageEntryNodes)
            {
                response.StageEntries.Add(StageEntry.Parse(stageEntryNode));
            }

            // Matches
            var matchNodes = doc.SelectNodes("/VISUALXML/GROUP[@ID='Result']/GROUP[@ID='Tournament']/GROUP[@ID='Matches']/GROUP[@ID='Match']");
            foreach (XmlNode matchNode in matchNodes)
            {
                response.Matches.Add(Match.Parse(matchNode));
            }

            // MatchWarnings
            var matchWarningNodes = doc.SelectNodes("/VISUALXML/GROUP[@ID='Result']/GROUP[@ID='Tournament']/GROUP[@ID='MatchWarnings']/GROUP[@ID='MatchWarning']");
            foreach (XmlNode matchWarningNode in matchWarningNodes)
            {
                response.MatchWarnings.Add(MatchWarning.Parse(matchWarningNode));
            }

            return response;
        }
    }
}
