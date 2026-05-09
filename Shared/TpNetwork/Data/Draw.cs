using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Draw
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public string Name { get; set; }
        public int DrawTypeID { get; set; }
        public int DrawEndSize { get; set; }
        public int StageID { get; set; }
        public int ConsolationTypeID { get; set; }
        public int LastFeedinRound { get; set; }
        public int PlayOffSize { get; set; }
        public int Position { get; set; }
        public int CosolationPlayOffSize { get; set; }
        public int DisplayOrder { get; set; }
        public int Columns { get; set; }

        public static Draw Parse(XmlNode node)
        {
            var draw = new Draw();
            draw.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            draw.EventID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='EventID']").InnerText);
            draw.Name = node.SelectSingleNode("ITEM[@ID='Name']").InnerText;
            draw.DrawTypeID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='DrawTypeID']").InnerText);
            draw.DrawEndSize = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='DrawEndSize']").InnerText);
            draw.StageID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='StageID']").InnerText);
            draw.ConsolationTypeID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ConsolationTypeID']").InnerText);
            draw.LastFeedinRound = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='LastFeedinRound']").InnerText);
            draw.PlayOffSize = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='PlayOffSize']").InnerText);
            draw.Position = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Position']").InnerText);
            draw.CosolationPlayOffSize = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='CosolationPlayOffSize']")?.InnerText);
            draw.DisplayOrder = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='DisplayOrder']").InnerText);
            draw.Columns = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Columns']").InnerText);
            return draw;
        }
    }
}
