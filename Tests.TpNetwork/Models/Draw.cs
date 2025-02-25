using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Tests.TpNetwork.Data;

namespace Tests.TpNetwork.Models
{
    public class Draw : DrawData
    {
        public List<PlayerMatch> Matches { get; private set; } = new List<PlayerMatch>();
        public List<Link> Links { get; private set; }
        protected Draw(DrawData raw) : base(raw)
        {
            Matches = new List<PlayerMatch>();
        }
        public static Draw Parse(DrawData raw, IEnumerable<PlayerMatchData> playerMatches, IEnumerable<Entry> entries, IEnumerable<Link> links)
        {
            Draw draw = new Draw(raw);
            if (draw.DrawType == DrawTypes.RoundRobin)
            {
                draw.Matches = PlayerMatch.ParsePoolDraw(draw, playerMatches, entries, links).ToList();
            }
            else
            {
                draw.Matches = PlayerMatch.TraverseCupDraw(draw, playerMatches, entries, links).ToList();
            }

            draw.Links = draw.Matches.Select(m => m.Links.Item1).Concat(draw.Matches.Select(m => m.Links.Item2)).Distinct().Where(link => link != null).ToList();
            return draw;
        }

        public static Draw Parse(XmlReader reader, List<Entry> entries)
        {
            Draw draw = new Draw(new DrawData(reader));
            List<PlayerMatchData> playerMatches = new List<PlayerMatchData>();
            while (reader.ReadToFollowing("MATCH"))
            {
                using (var matchXml = reader.ReadSubtree())
                {
                    matchXml.Read();
                    playerMatches.Add(new PlayerMatchData(matchXml)
                    {
                        DrawID = draw.Id,
                        EventID = draw.EventId
                    });
                }
            }

            if (draw.DrawType == DrawTypes.RoundRobin)
            {
                draw.Matches.AddRange(PlayerMatch.ParsePoolDrawXML(draw, playerMatches, entries));
            }
            else
            {
                draw.Matches.AddRange(PlayerMatch.TraverseCupDrawXML(draw, playerMatches, entries));
            }

            return draw;
        }

        public IEnumerable<Entry> GetEntries()
        {
            return Matches.Select(match => match.Entries.Item1).Concat(Matches.Select(match => match.Entries.Item2)).Where(entry => entry != null).Distinct();
        }

        /*
            public List<PlayerMatch> Matches { get; private set; } = new List<PlayerMatch>();
            public int EntryCount { get; set; }


            public Draw(XmlReader reader, List<Entry> entries) {
              ID = GetInt(reader, "ID");
              DrawType = (DrawTypes)GetInt(reader, "DRAWTYPE");
              Name = GetString(reader, "DRAWNAME");
              EntryCount = entries.Count;
              while (reader.ReadToFollowing("MATCH")) {
                Matches.Add(new PlayerMatch(reader));
              }
              Matches.ForEach(match => match.Entry = match.EntryID == 0 ? null : entries.Find(entry => entry.ID == match.EntryID));
            }

            public ScoreboardLiveApi.TournamentClass MakeScoreboardClass() {
              return new ScoreboardLiveApi.TournamentClass {
                Description = Name,
                Size = DrawSize(),
                ClassType = DrawType switch {
                  DrawTypes.RoundRobin => "roundrobin",
                  _ => "cup"
                }
              };
            }

            public int DrawSize() {
              return Matches.FindAll(match => match.Entry != null).Select(match => match.Entry).Distinct().Count() +
                     Matches.FindAll(match => match.Link != null).Count();
            }
        */

        public override string ToString()
        {
            return string.Format("DRAW {0}\t{1}\t{2}", Id, Name, DrawType);
            //return string.Format("DRAW {0}\t{1}\t{2}\t({3} matches)", ID, Name, DrawType, Matches.Count);
        }
    }
}