using BCA.WerZaehltWo3.Shared.Helpers;
using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class MatchWarning
    {
        public int ID { get; set; }
        public string GUID { get; set; }
        public int MatchID { get; set; }
        public int PlayerID { get; set; }
        public DateTime PlayTime { get; set; }
        public int Status { get; set; }
        public DateTime TimeStamp { get; set; }

        public static MatchWarning Parse(XmlNode node)
        {
            var match = new MatchWarning();
            match.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            match.GUID = node.SelectSingleNode("ITEM[@ID='GUID']").InnerText;
            match.MatchID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MatchID']").InnerText);
            match.PlayerID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='PlayerID']").InnerText);
            match.PlayTime = VisualXmlHelpers.GetDateTime(node.SelectSingleNode("ITEM[@ID='PlayTime']/DATETIME"));
            match.Status = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Status']").InnerText);
            match.TimeStamp = VisualXmlHelpers.GetDateTime(node.SelectSingleNode("ITEM[@ID='TimeStamp']/DATETIME"));
            return match;
        }
    }
}
