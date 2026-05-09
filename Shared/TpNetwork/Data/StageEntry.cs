using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class StageEntry
    {
        public int ID { get; set; }
        public int StageID { get; set; }
        public int EntryID { get; set; }
        public int Status { get; set; }
        public int Seed1 { get; set; }
        public int Seed2 { get; set; }

        public static StageEntry Parse(XmlNode node)
        {
            var stageEntry = new StageEntry();
            stageEntry.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            stageEntry.StageID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='StageID']").InnerText);
            stageEntry.EntryID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='EntryID']").InnerText);
            stageEntry.Status = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Status']").InnerText);
            stageEntry.Seed1 = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Seed1']")?.InnerText);
            stageEntry.Seed2 = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='Seed2']")?.InnerText);
            return stageEntry;
        }
    }
}