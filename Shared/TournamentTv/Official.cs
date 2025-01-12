using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class Official : TtvDataObject
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Munknown { get; set; }
        public string Country { get; set; }
        public int Id { get; set; }

        public Official(XmlNode node)
        {
            this.LastName = GetString(node, "N");
            this.FirstName = GetString(node, "F");
            this.Munknown = GetString(node, "M");
            this.Country = GetString(node, "C");
            this.Id = GetInt(node, "ID");
        }
    }
}