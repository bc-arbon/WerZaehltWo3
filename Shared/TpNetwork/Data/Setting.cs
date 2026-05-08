using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Setting
    {
        public string ID { get; set; }
        public string IDType { get; set; }
        public string Value { get; set; }
        public string ValueType { get; set; }

        public static Setting Parse(XmlNode node)
        {
            var setting = new Setting();
            setting.ID = node.SelectSingleNode("ITEM[@ID='ID']").InnerText;
            setting.IDType = node.SelectSingleNode("ITEM[@ID='ID']").Attributes["TYPE"].Value;
            setting.Value = node.SelectSingleNode("ITEM[@ID='Value']").InnerText;
            setting.ValueType = node.SelectSingleNode("ITEM[@ID='Value']").Attributes["TYPE"].Value;

            return setting;
        }
    }
}
