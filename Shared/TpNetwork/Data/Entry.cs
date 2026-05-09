using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Entry
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int Player1ID { get; set; }
        public int Player2ID { get; set; }

        public static Entry Parse(XmlNode node)
        {
            var entry = new Entry();
            entry.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            entry.EventID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='EventID']").InnerText);
            entry.Player1ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Player1ID']").InnerText);
            entry.Player2ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Player2ID']")?.InnerText);
            return entry;
        }
    }
}