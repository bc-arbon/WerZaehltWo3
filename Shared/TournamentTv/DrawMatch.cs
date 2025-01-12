using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class DrawMatch : TtvDataObject
    {
        public int Id { get; set; }
        public int Planning { get; set; }
        public int EntryId { get; set; }
        public string Link { get; set; }
        public string Court {  get; set; }
        public string Playtime { get; set; }
        public int RoundNr { get; set; }
        public string RoundName { get; set; }
        public int MatchNr { get; set; }

        public DrawMatch(XmlNode node)
        {
            this.Id = GetInt(node, "ID");
            this.Planning = GetInt(node, "PLANNING");
            this.EntryId = GetInt(node, "ENTRY");
            this.Link = GetString(node, "LINK");
            this.Court = GetString(node, "COURT");
            this.Playtime = GetString(node, "PLAYTIME");
            this.RoundNr = GetInt(node, "ROUNDNR");
            this.RoundName = GetString(node, "ROUNDNAME");
            this.MatchNr = GetInt(node, "MATCHNR");
        }
    }
}