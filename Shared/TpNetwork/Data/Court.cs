using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Court
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int LocationID { get; set; }
        public int MatchID { get; set; }
        public int SortOrder { get; set; }

        public static Court Parse(XmlNode node)
        {
            var court = new Court();
            court.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            court.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            court.LocationID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='LocationID']").InnerText);
            court.MatchID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MatchID']")?.InnerText);
            court.SortOrder = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='SortOrder']").InnerText);
            return court;
        }
    }
}
