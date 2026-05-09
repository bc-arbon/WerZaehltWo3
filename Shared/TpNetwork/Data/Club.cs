using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Club
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static Club Parse(XmlNode node)
        {
            var club = new Club();
            club.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            club.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            return club;
        }
    }
}
