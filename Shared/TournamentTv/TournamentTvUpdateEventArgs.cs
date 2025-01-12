using System;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class TournamentTvUpdateEventArgs
    {
        public DateTime DateTime { get; set; }
        public Tournament Tournament { get; set; }

        public TournamentTvUpdateEventArgs(Tournament tournament)
        {
            this.DateTime = DateTime.Now;
            this.Tournament = tournament;
        }
    }
}