using System;

namespace BCA.WerZaehltWo3.Shared.Eventing
{
    public class SetTsDataEventArgs : EventArgs
    {
        public TsDataType Type { get; set; }
        public int Court {  get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
    }
}
