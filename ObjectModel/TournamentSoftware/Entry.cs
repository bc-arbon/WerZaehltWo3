using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.ObjectModel.TournamentSoftware
{
    public class Entry
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public int Player1Id { get; set; }

        public string Player1 { get; set; }

        public int Player2Id { get; set; }

        public string Player2 { get; set; }

        public int PlanningId { get; set; }
    }
}
