using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Link
    {
        public int ID { get; set; }
        public int DrawID { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }

        public static Link Parse(XmlNode node)
            {
                var link = new Link();
                link.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
                link.DrawID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='DrawID']").InnerText);
                link.Position = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Position']").InnerText);
                link.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
                return link;
        }
    }
}