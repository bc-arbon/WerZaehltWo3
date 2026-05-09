using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Official
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Country { get; set; }

        public static Official Parse(XmlNode node)
        {
            var official = new Official();
            official.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            official.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            official.FirstName = node.SelectSingleNode("ITEM[@ID='FirstName']").InnerText;
            official.Country = node.SelectSingleNode("ITEM[@ID='Country']")?.InnerText;
            return official;
        }
    }
}
