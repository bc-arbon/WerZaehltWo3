using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class VisualDraw : TtvDataObject
    {
        public int Id { get; set; }
        public int SheetId { get; set; }
        public string DrawName { get; set; }
        public string TabName { get; set; }
        public int DrawSubType { get; set; }
        public int DrawId { get; set; }

        public VisualDraw(XmlNode node)
        {
            this.Id = GetInt(node, "ID");
            this.SheetId = GetInt(node, "SHEETID");
            this.DrawName = GetString(node, "DRAWNAME");
            this.TabName = GetString(node, "TABNAME");
            this.DrawSubType = GetInt(node, "DRAWSUBTYPE");
            this.DrawId = GetInt(node, "DRAWID");
        }
    }
}