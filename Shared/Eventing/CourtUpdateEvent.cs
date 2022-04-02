using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Shared.Eventing
{
    public class CourtUpdateEvent
    {
        public CourtUpdateEvent(Court court)
        {
            this.Court = court;
        }

        public Court Court { get; private set; }
    }
}
