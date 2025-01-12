using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class Standing : TtvDataObject
    {
        public int Planning { get; set; }
        public int EntryId { get; set; }
        public string Link { get; set; }
        public string Stats { get; set; }
        public int Rank { get; set; }
        public int Played {  get; set; }
        public int Points { get; set; }
        public int Bhz { get; set; }

        public Standing(XmlNode node)
        {
            this.Planning = GetInt(node, "PLANNING");
            this.EntryId = GetInt(node, "ENTRY");
            this.Link = GetString(node, "LINK");
            this.Stats = GetString(node, "STATS");
            this.Rank = GetInt(node, "RANK");
            this.Played = GetInt(node, "PL");
            this.Points = GetInt(node, "PT");
            this.Bhz = GetInt(node, "BHZ");
        }
    }
}