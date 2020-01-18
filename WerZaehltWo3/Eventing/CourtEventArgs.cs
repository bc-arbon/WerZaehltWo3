namespace BCA.WerZaehltWo3.Eventing
{
    using System;

    using BCA.WerZaehltWo3.ObjectModel;

    public class CourtEventArgs : EventArgs
    {
        public CourtEventArgs(Court court)
        {
            this.Court = court;
        }

        public Court Court { get; }
    }
}