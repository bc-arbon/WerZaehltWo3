using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class District
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public static District Parse(XmlNode node)
        {
            var district = new District();
            district.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            district.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            district.Abbreviation = node.SelectSingleNode("ITEM[@ID='Abbreviation']")?.InnerText;
            return district;
        }
    }
}
