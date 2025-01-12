using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class DisplayMatchSet : TtvDataObject
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }

        public DisplayMatchSet(XmlNode node)
        {
            this.Score1 = GetInt(node, "S1");
            this.Score2 = GetInt(node, "S2");
        }
    }
}