using BCA.WerZaehltWo3.Shared.TPNetwork.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCA.WerZaehltWo3.Shared.TPNetwork.Models
{
    public partial class Tournament
    {
        public List<TournamentInformation> TournamentInformation { get; private set; } = new List<TournamentInformation>();
        public List<LocationData> Locations { get; private set; } = new List<LocationData>();
        public List<Court> Courts { get; private set; } = new List<Court>();
        public List<Entry> Entries { get; private set; } = new List<Entry>();
        public List<Event> Events { get; private set; } = new List<Event>();

        public PlayerMatch FindMatchByID(int id)
        {
            foreach (Event e in Events)
            {
                foreach (Draw draw in e.Draws)
                {
                    var match = draw.Matches.Where(m => m.ID == id).FirstOrDefault();
                    if (match != null)
                    {
                        return match;
                    }
                }
            }

            return null;
        }

        public Event FindEventByID(int id)
        {
            return Events.Where(e => e.ID == id).FirstOrDefault();
        }

        public Draw FindDrawByID(int id)
        {
            foreach (Event e in Events)
            {
                var draw = e.Draws.Where(d => d.Id == id).FirstOrDefault();
                if (draw != null)
                {
                    return draw;
                }
            }

            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-- TOURNAMENT --");
            sb.AppendLine("Tournament information:");
            foreach (var ti in TournamentInformation)
            {
                sb.AppendLine(ti.ToString());
            }

            sb.AppendLine("Courts:");
            foreach (var court in Courts)
            {
                sb.AppendLine(court.ToString());
            }

            sb.AppendLine("Entries:");
            foreach (var entry in Entries)
            {
                sb.AppendLine(entry.ToString());
            }

            sb.AppendLine("Events:");
            foreach (var ev in Events)
            {
                sb.AppendLine(ev.ToString());
            }

            return sb.ToString();
        }
    }
}