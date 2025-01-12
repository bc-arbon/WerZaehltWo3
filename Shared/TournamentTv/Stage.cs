using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class Stage : TtvDataObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StageType { get; set; }

        public Stage(XmlNode node)
        {
            this.Id = GetInt(node, "ID");
            this.Name = GetString(node, "NAME");
            this.StageType = GetInt(node, "STAGETYPE");
        }
    }
}