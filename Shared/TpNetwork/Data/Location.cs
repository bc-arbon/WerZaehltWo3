using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public static Location Parse(XmlNode node)
        {
            var location = new Location();
            location.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            location.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            location.Address1 = node.SelectSingleNode("ITEM[@ID='Address1']").InnerText;
            location.PostalCode = node.SelectSingleNode("ITEM[@ID='PostalCode']").InnerText;
            location.City = node.SelectSingleNode("ITEM[@ID='City']").InnerText;
            location.Country = node.SelectSingleNode("ITEM[@ID='Country']").InnerText;
            return location;
        }
    }
}