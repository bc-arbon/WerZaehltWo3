using BCA.WerZaehltWo3.Shared.TPNetwork.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCA.WerZaehltWo3.Shared.TPNetwork.Models
{
    public class PlayerMatch : PlayerMatchData
    {
        public (Entry, Entry) Entries { get; set; }
        public (Link, Link) Links { get; set; }
        public PlayerMatch Parent { get; set; }
        public (PlayerMatch, PlayerMatch) Source { get; set; }

        protected PlayerMatch(PlayerMatchData raw, Entry entry1, Entry entry2) : base(raw)
        {
            Entries = (entry1, entry2);
        }

        public IEnumerable<PlayerMatch> Flatten()
        {
            List<PlayerMatch> flatTree = new List<PlayerMatch>();
            flatTree.Add(this);
            if (Source.Item1 != null)
            {
                flatTree.AddRange(Source.Item1.Flatten());
            }

            if (Source.Item2 != null)
            {
                flatTree.AddRange(Source.Item2.Flatten());
            }

            return flatTree;
        }

        public static PlayerMatch Parse(PlayerMatchData raw, IEnumerable<PlayerMatchData> playerMatches, IEnumerable<Entry> entries, IEnumerable<Link> links)
        {
            // If this match does not have any 'van1' or 'van2', it's a base item and should be ignored, search can stop here
            if ((raw.Van1 == 0) || (raw.Van2 == 0))
            {
                return null;
            }

            // Find the van's
            PlayerMatchData van1 = playerMatches.First(pm => (pm.Planning == raw.Van1) && (pm.DrawID == raw.DrawID));
            PlayerMatchData van2 = playerMatches.First(pm => (pm.Planning == raw.Van2) && (pm.DrawID == raw.DrawID));
            
            // Create match
            PlayerMatch match = new PlayerMatch(raw, entries.FirstOrDefault(entry => entry.Id == van1?.EntryID), entries.FirstOrDefault(entry => entry.Id == van2?.EntryID));

            // Find any links
            Link link1 = (van1?.LinkID > 0) ? links.FirstOrDefault(link => link.ID == van1.LinkID) : null;
            Link link2 = (van2?.LinkID > 0) ? links.FirstOrDefault(link => link.ID == van2.LinkID) : null;
            match.Links = (link1, link2);
            return match;
        }

        /*
        public static Match Parse(XmlReader reader) {
          for (int i = 1; i<= 4; i++) {
            string playerName = string.Format("{0} {1}",
                                              GetString(reader, string.Format("N{0}", i)),
                                              GetString(reader, string.Format("N{0}", i)));

          }
        }*/

        public static IEnumerable<PlayerMatch> ParsePoolDraw(Draw draw, IEnumerable<PlayerMatchData> playerMatches, IEnumerable<Entry> entries, IEnumerable<Link> links)
        {
            List<PlayerMatch> matches = new List<PlayerMatch>();
            foreach (var pm in playerMatches.Where(pm => (pm.DrawID == draw.Id) && (pm.Van1 > 0) && (pm.Van2 > 0) && (pm.Van1 < pm.Van2)))
            {
                matches.Add(Parse(pm, playerMatches, entries, links));
            }

            return matches;
        }

        public static IEnumerable<PlayerMatch> ParsePoolDrawXML(Draw draw, IEnumerable<PlayerMatchData> playerMatches, IEnumerable<Entry> entries)
        {
            // Find valid matches
            var validMatches = playerMatches.Where(pm => (pm.Planning % 1000 != 0) && (pm.Planning / 1000 < pm.Planning % 1000));

            // Set the VAN, so we can use the same parse as for the TP file
            foreach (var match in validMatches)
            {
                match.Van1 = (match.Planning / 1000) * 1000;
                match.Van2 = (match.Planning % 1000) * 1000;
            }

            return validMatches.Select(match => Parse(match, playerMatches, entries, new List<Link>()));
        }

        public static IEnumerable<PlayerMatch> TraverseCupDraw(Draw draw, IEnumerable<PlayerMatchData> playerMatches, IEnumerable<Entry> entries, IEnumerable<Link> links)
        {
            // Find the root matches (a TP draw can have many roots, used for example in qualifiers)
            IEnumerable<Data.PlayerMatchData> roots = playerMatches.Where(pm => (pm.DrawID == draw.Id) && (pm.WN == 0));
            List<PlayerMatch> matches = new List<PlayerMatch>();

            // Go through all roots and parse the corresponding trees
            foreach (Data.PlayerMatchData root in roots)
            {
                PlayerMatch parsedRoot = ParseMatchNode(root, null, playerMatches, entries, links);
                if (parsedRoot != null)
                {
                    matches.AddRange(parsedRoot.Flatten());
                }
            }

            return matches;
        }

        public static IEnumerable<PlayerMatch> TraverseCupDrawXML(Draw draw, IEnumerable<PlayerMatchData> playerMatches, IEnumerable<Entry> entries)
        {
            // Find the root matches (the ones with the lowest planning "thousands")
            int lowestPlanningThousands = playerMatches.Aggregate(100, (lowest, match) => match.Planning / 1000 < lowest ? match.Planning / 1000 : lowest);
            var roots = playerMatches.Where(match => match.Planning / 1000 == lowestPlanningThousands);
            
            // Find the highest order planning "thousands"
            int highestPlanningThousands = playerMatches.Aggregate(1, (highest, match) => match.Planning / 1000 > highest ? match.Planning / 1000 : highest);
            
            // Set the VANS, so that we can use the tp-file parser
            foreach (var match in playerMatches)
            {
                if (match.Planning / 1000 >= highestPlanningThousands) continue;
                match.Van1 = (match.Planning / 1000 + 1) * 1000 + (match.Planning % 1000) * 2 - 1;
                match.Van2 = (match.Planning / 1000 + 1) * 1000 + (match.Planning % 1000) * 2;
            }
            
            // Go through all roots and add matches
            List<PlayerMatch> matches = new List<PlayerMatch>();
            foreach (PlayerMatchData root in roots)
            {
                PlayerMatch parsedRoot = ParseMatchNode(root, null, playerMatches, entries, new List<Link>());
                if (parsedRoot != null)
                {
                    matches.AddRange(parsedRoot.Flatten());
                }
            }

            return matches;
        }

        private static PlayerMatch ParseMatchNode(PlayerMatchData node, PlayerMatch parent, IEnumerable<PlayerMatchData> playerMatches, IEnumerable<Entry> entries, IEnumerable<Link> links)
        {
            PlayerMatch match = Parse(node, playerMatches, entries, links);
            if (match == null)
            {
                return null;
            }

            PlayerMatchData van1 = playerMatches.First(pm => (pm.Planning == node.Van1) && (pm.DrawID == node.DrawID));
            PlayerMatchData van2 = playerMatches.First(pm => (pm.Planning == node.Van2) && (pm.DrawID == node.DrawID));

            match.Parent = parent;
            match.Source = (ParseMatchNode(van1, match, playerMatches, entries, links), ParseMatchNode(van2, match, playerMatches, entries, links));

            return match;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Match {0} ({1})", ID, PlanDate.ToString()));
            sb.AppendLine(Entries.Item1?.ToString() ?? "<empty>");
            sb.AppendLine(Entries.Item2?.ToString() ?? "<empty>");
            return sb.ToString();
        }
    }
}