using System.Collections.Generic;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class Tournament : TtvDataObject
    {
        public string Product {  get; set; }
        public string Sport { get; set; }
        public string Version { get; set; }
        public string ClubName { get; set; }
        public string Organization { get; set; }
        public string Stats { get; set; }
        public List<DisplayMatch> MatchesOnCourt { get; private set; } = new List<DisplayMatch>();
        public List<DisplayMatch> MatchesFinished { get; private set; } = new List<DisplayMatch>();
        public List<DisplayMatch> MatchesScheduled { get; private set; } = new List<DisplayMatch>();
        public List<Event> Events { get; private set; } = new List<Event>();
        public List<VisualDraw> VisualDraws { get; private set; } = new List<VisualDraw>();

        public Tournament(XmlNode node)
        {
            this.Product = GetString(node, "Product");
            this.Sport = GetString(node, "Sport");
            this.Version = GetString(node, "Version");
            this.ClubName = GetString(node, "ClubName");
            this.Organization = GetString(node, "Organization");
            this.Stats = GetString(node, "Stats");

            var onCourtNodes = node.SelectNodes("MATCHES/ONCOURT/MATCH");
            foreach (XmlNode matchNode in onCourtNodes)
            {
                this.MatchesOnCourt.Add(new DisplayMatch(matchNode));
            }

            var finishedNodes = node.SelectNodes("MATCHES/FINISHED/MATCH");
            foreach (XmlNode matchNode in finishedNodes)
            {
                this.MatchesFinished.Add(new DisplayMatch(matchNode));
            }

            var scheduledNodes = node.SelectNodes("MATCHES/SCHEDULED/MATCH");
            foreach (XmlNode matchNode in scheduledNodes)
            {
                this.MatchesScheduled.Add(new DisplayMatch(matchNode));
            }

            var eventNodes = node.SelectNodes("EVENTS/EVENT");
            foreach (XmlNode eventNode in eventNodes)
            {
                this.Events.Add(new Event(eventNode));
            }

            var visualDrawNodes = node.SelectNodes("VISUALDRAWS/VISUALDRAW");
            foreach (XmlNode visualDrawNode in visualDrawNodes)
            {
                this.VisualDraws.Add(new VisualDraw(visualDrawNode));
            }
        }

        //public PlayerMatch FindMatchByID(int id)
        //{
        //    foreach (Event e in Events)
        //    {
        //        foreach (Draw draw in e.Draws)
        //        {
        //            var match = draw.Matches.Where(m => m.ID == id).FirstOrDefault();
        //            if (match != null)
        //            {
        //                return match;
        //            }
        //        }
        //    }

        //    return null;
        //}

        //public Event FindEventByID(int id)
        //{
        //    return Events.Where(e => e.ID == id).FirstOrDefault();
        //}

        //public Draw FindDrawByID(int id)
        //{
        //    foreach (Event e in Events)
        //    {
        //        var draw = e.Draws.Where(d => d.Id == id).FirstOrDefault();
        //        if (draw != null)
        //        {
        //            return draw;
        //        }
        //    }

        //    return null;
        //}

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("-- TOURNAMENT --");
        //    sb.AppendLine("Tournament information:");
        //    foreach (var ti in TournamentInformation)
        //    {
        //        sb.AppendLine(ti.ToString());
        //    }

        //    sb.AppendLine("Courts:");
        //    foreach (var court in Courts)
        //    {
        //        sb.AppendLine(court.ToString());
        //    }

        //    sb.AppendLine("Entries:");
        //    foreach (var entry in Entries)
        //    {
        //        sb.AppendLine(entry.ToString());
        //    }

        //    sb.AppendLine("Events:");
        //    foreach (var ev in Events)
        //    {
        //        sb.AppendLine(ev.ToString());
        //    }

        //    return sb.ToString();
        //}
    }
}