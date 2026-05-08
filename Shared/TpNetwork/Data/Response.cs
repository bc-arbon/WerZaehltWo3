using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.TpNetwork.Data;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork
{
    public class Response
    {
        public Response()
        {
            this.Settings = new List<Setting>();
            this.TournamentDays = new List<TournamentDay>();
            this.ScoringFormats = new List<ScoringFormat>();
            this.Matches = new List<Match>();
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

        public static Response Parse(string xml)
        {
            var response = new Response();
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            response.VersionHi = Convert.ToInt32(doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Header']/GROUP[@ID='Version']/ITEM[@ID='Hi']").InnerText);
            response.VersionLo = Convert.ToInt32(doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Header']/GROUP[@ID='Version']/ITEM[@ID='Lo']").InnerText);

            response.ActionID = doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Action']/ITEM[@ID='ID']").InnerText;
            response.Password = doc.SelectSingleNode("VISUALXML/GROUP[@ID='Action']/ITEM[@ID='Password']").InnerText;
            response.Unicode = doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Action']/ITEM[@ID='Unicode']").InnerText;
            response.Action = doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Action']/ITEM[@ID='Action']").InnerText;
            response.Result = Convert.ToInt32(doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Action']/ITEM[@ID='Result']").InnerText);

            response.ClientIp = doc.SelectSingleNode("/VISUALXML/GROUP[@ID='Client']/ITEM[@ID='IP']").InnerText;
            response.Xml = xml;

            // Settings
            var settingNodes = doc.SelectNodes("/VISUALXML/GROUP[@ID='Result']/GROUP[@ID='Tournament']/GROUP[@ID='Settings']/GROUP[@ID='Setting']");
            foreach (XmlNode settingNode in settingNodes)
            {                
                response.Settings.Add(Setting.Parse(settingNode));
            }

            // TournamentDays
            var tournamentDayNodes = doc.SelectNodes("/VISUALXML/GROUP[@ID='Result']/GROUP[@ID='Tournament']/GROUP[@ID='TournamentDays']/GROUP[@ID='TournamentDay']");
            foreach (XmlNode tournamentDayNode in tournamentDayNodes)
            {                
                response.TournamentDays.Add(TournamentDay.Parse(tournamentDayNode));
            }

            // ScoringFormats
            var scoringFormatNodes = doc.SelectNodes("/VISUALXML/GROUP[@ID='Result']/GROUP[@ID='Tournament']/GROUP[@ID='ScoringFormats']/GROUP[@ID='ScoringFormat']");
            foreach (XmlNode scoringFormatNode in scoringFormatNodes)
            {
                response.ScoringFormats.Add(ScoringFormat.Parse(scoringFormatNode));
            }

            // Events TODO

            // Stages TODO

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
