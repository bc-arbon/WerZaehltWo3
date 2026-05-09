using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int GameTypeID { get; set; }
        public int GenderID { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public double Fee { get; set; }
        public bool SeparateSeeding { get; set; }
        public bool AllowOnlineEntry { get; set; }
        public int GradingID { get; set; }
        public int SubGradingID { get; set; }
        public int SubGrading2ID { get; set; }
        public int Max_Age { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }

        public static Event Parse(XmlNode node)
        {
            var result = new Event();
            result.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            result.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            result.GameTypeID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='GameTypeID']").InnerText);
            result.GenderID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='GenderID']").InnerText);
            result.MinAge = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MinAge']").InnerText);
            result.MaxAge = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MaxAge']").InnerText);
            result.Fee = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='Fee']").InnerText);
            result.SeparateSeeding = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='SeparateSeeding']").InnerText);
            result.AllowOnlineEntry = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='AllowOnlineEntry']").InnerText);
            result.GradingID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='GradingID']").InnerText);
            result.SubGradingID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='SubGradingID']").InnerText);
            result.SubGrading2ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='SubGrading2ID']").InnerText);
            result.Max_Age = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Max_Age']").InnerText);
            result.MinWeight = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MinWeight']").InnerText);
            result.MaxWeight = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MaxWeight']").InnerText);
            return result;
        }
    }
}