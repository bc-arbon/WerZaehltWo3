using System;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class TournamentTvUpdateEventArgs
    {
        public DateTime DateTime { get; set; }
        public Tournament Tournament { get; set; }
        public string XmlData { get; set; }

        public TournamentTvUpdateEventArgs(Tournament tournament, string xmlData)
        {
            this.DateTime = DateTime.Now;
            this.Tournament = tournament;
            XmlData = xmlData;
        }
    }
}