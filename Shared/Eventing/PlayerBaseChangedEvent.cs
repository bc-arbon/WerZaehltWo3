using System.Collections.Generic;

namespace BCA.WerZaehltWo3.Shared.Eventing
{
    public class PlayerBaseChangedEvent
    {
        public PlayerBaseChangedEvent()
        {
            this.Players = new List<string>();
        }

        public List<string> Players { get; set; }
    }
}
