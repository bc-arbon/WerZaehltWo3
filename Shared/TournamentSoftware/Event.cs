using BCA.WerZaehltWo3.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.Shared.TournamentSoftware
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public EventType EventType { get; set; }

        public Gender Gender { get; set; }
    }
}
