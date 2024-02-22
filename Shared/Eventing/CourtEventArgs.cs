using System;
using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Shared.Eventing
{
    public class CourtEventArgs : EventArgs
    {
        public CourtEventArgs(Court court)
        {
            this.Court = court;
        }

        public Court Court { get; }
    }
}