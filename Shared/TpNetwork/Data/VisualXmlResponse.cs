using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.TpNetwork.Data;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

            // Districts TODO

            // Clubs TODO

            // Locations TODO

            // Officials TODO

            // Draws TODO

            // Courts TODO

            // Links TODO

            // Players TODO

            // Payments TODO

            // Entries TODO

            // StageEntries TODO

            // Matches
            var matchNodes = doc.SelectNodes("/VISUALXML/GROUP[@ID='Result']/GROUP[@ID='Tournament']/GROUP[@ID='Matches']/GROUP[@ID='Match']");
            foreach (XmlNode matchNode in matchNodes)
            {
                response.Matches.Add(Match.Parse(matchNode));
            }

            // MatchWarnings TODO

            return response;
        }
    }
}
