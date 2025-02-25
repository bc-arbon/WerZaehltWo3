using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Tests.TpNetwork.Data;

namespace Tests.TpNetwork.Models
{
    public class Event : EventData
    {
        public TournamentInformation TournamentInformation { get; private set; }
        public List<Draw> Draws { get; private set; } = new List<Draw>();

        public Event(EventData raw) : base(raw) { }

        public static Event Parse(EventData raw, IEnumerable<Draw> draws, IEnumerable<TournamentInformation> tournamentInformation)
        {
            Event tpEvent = new Event(raw);
            tpEvent.Draws = draws.Where(draw => draw.EventId == tpEvent.ID).ToList();
            tpEvent.TournamentInformation = tournamentInformation.FirstOrDefault(ti => ti.ID == tpEvent.TournamentInformationID);
            return tpEvent;
        }

        public static Event Parse(XmlReader reader)
        {
            reader.Read();
            Event newEvent = new Event(new EventData(reader));

            List<Entry> entries = new List<Entry>();
            reader.ReadToFollowing("ENTRIES");
            using (var entriesXml = reader.ReadSubtree())
            {
                entriesXml.Read();
                while (entriesXml.ReadToFollowing("ENTRY"))
                {
                    entries.Add(Entry.Parse(entriesXml));
                }
            }

            List<Draw> draws = new List<Draw>();
            reader.ReadToFollowing("DRAWS");
            using (var drawsXml = reader.ReadSubtree())
            {
                while (drawsXml.ReadToFollowing("DRAW"))
                {
                    using (var subtree = drawsXml.ReadSubtree())
                    {
                        subtree.Read();
                        draws.Add(Draw.Parse(subtree, entries));
                    }
                }
            }

            newEvent.Draws = draws;


            return newEvent;
        }

        /*
        public Event(XmlReader reader) {
          ID = GetInt(reader, "ID");
          Name = GetString(reader, "NAME");
          List<Entry> entries = new List<Entry>();
          if (reader.ReadToDescendant("ENTRIES")) {
            using (var subtree = reader.ReadSubtree()) {
              while (subtree.ReadToFollowing("ENTRY")) {
                entries.Add(new Entry(subtree));
              }
            }
          }
          while (reader.ReadToFollowing("DRAW")) {
            using (var subtree = reader.ReadSubtree()) {
              Draws.Add(new Draw(subtree, entries));
            }
          }
        }

        public string CreateMatchCategoryString() {
          return Gender switch {
            Genders.Men => EventType == EventTypes.Singles ? "ms" : "md",
            Genders.Boys => EventType == EventTypes.Singles ? "ms" : "md",
            Genders.Women => EventType == EventTypes.Singles ? "ws" : "wd",
            Genders.Girls => EventType == EventTypes.Singles ? "ws" : "wd",
            _ => "xd",
          };
        }


        public List<PlayerMatch> ExtractMatches() {
          List<PlayerMatch> matches = new List<PlayerMatch>();
          foreach (Draw draw in Draws) {
            matches.AddRange(draw.Matches);
          }
          return matches;
        }

        public (PlayerMatch, Entry, Entry) FindMatchAndEntries(Predicate<PlayerMatch> finder) {
          foreach (Draw draw in Draws) {
            var found = draw.Matches.Find(finder);
            if (found != null) {
              var entry1 = draw.Matches.Find(match => match.Planning == found.Van1);
              var entry2 = draw.Matches.Find(match => match.Planning == found.Van2);
              return (found, entry1?.Entry, entry2?.Entry);
            }
          }
          return (null, null, null);
         }
        */

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("EVENT {0}\t{1}\t{2}\t{3}{4}", ID, Name, Gender, EventType, Environment.NewLine);
            foreach (Draw draw in Draws)
            {
                sb.AppendFormat("\t{0}{1}", draw.ToString(), Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
