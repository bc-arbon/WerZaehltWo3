using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Set
    {
        public int T1 { get; set; }
        public int T2 { get; set; }

        public static Set Parse(XmlNode node)
        {
            var set = new Set();
            set.T1 = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='T1']").InnerText);
            set.T2 = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='T2']").InnerText);
            return set;
        }
    }
}
