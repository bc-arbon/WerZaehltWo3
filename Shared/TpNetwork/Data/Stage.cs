using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Stage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int EventID { get; set; }
        public int StateType { get; set; }
        public int DisplayOrder { get; set; }

        public static Stage Parse(XmlNode node)
        {
            var stage = new Stage();
            stage.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            stage.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            stage.EventID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='EventID']").InnerText);
            stage.StateType = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='StageType']").InnerText);
            stage.DisplayOrder = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='DisplayOrder']").InnerText);
            return stage;
        }
    }
}
