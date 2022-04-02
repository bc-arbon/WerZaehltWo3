using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Shared.Eventing
{
    public class TsCourtUpdateEvent
    {
        public TsCourtUpdateEvent(int courtNumber, DataType dataType, string player1, string player2)
        {
            this.CourtNumber = courtNumber;
            this.DataType = dataType;
            this.Player1 = player1;
            this.Player2 = player2;
        }

        public int CourtNumber { get; private set; }
        public DataType DataType { get; private set; }
        public string Player1 { get; private set; } 
        public string Player2 { get; private set; }
    }
}
