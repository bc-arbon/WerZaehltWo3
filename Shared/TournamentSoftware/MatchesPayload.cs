using BCA.WerZaehltWo3.Shared.TournamentSoftware;
using System;
using System.Collections.Generic;

namespace BCA.WerZaehltWo3.Common.TournamentSoftware
{
    public class MatchesPayload
    {
        public DateTime Timestamp { get; set; }
        public List<Match> CurrentMatches { get; set; }
        public List<Match> PlannedMatches { get; set; }
    }
}
