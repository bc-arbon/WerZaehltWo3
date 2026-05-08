using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class ScoringFormat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumSets { get; set; }
        public int SetType { get; set; }
        public int LastSetType { get; set; }
        public int Score { get; set; }
        public bool IsDefault { get; set; }
        
        public static ScoringFormat Parse(XmlNode node)
        {
            var format = new ScoringFormat();
            format.Id = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            format.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            format.NumSets = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='NumSets']").InnerText);
            format.SetType = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='SetType']").InnerText);
            format.LastSetType = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='LastSetType']").InnerText);
            format.Score = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Score']").InnerText);
            format.IsDefault = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='IsDefault']").InnerText);
            return format;
        }
    }
}
