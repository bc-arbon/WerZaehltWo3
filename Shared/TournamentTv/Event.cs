using System.Collections.Generic;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class Event : TtvDataObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Stage> Stages { get; set; } = new List<Stage>();
        public List<Entry> Entries { get; set; } = new List<Entry>();
        public List<Draw> Draws { get; set; } = new List<Draw>();

        public Event(XmlNode node)
        {
            this.Id = GetInt(node, "ID");
            this.Name = GetString(node, "NAME");

            var stageNodes = node.SelectNodes("STAGES/STAGE");
            foreach (XmlNode stageNode in stageNodes)
            {
                this.Stages.Add(new Stage(stageNode));
            }

            var entryNodes = node.SelectNodes("ENTRIES/ENTRY");
            foreach(XmlNode entryNode in entryNodes)
            {
                this.Entries.Add(new Entry(entryNode));
            }

            var drawNodes = node.SelectNodes("DRAWS/DRAW");
            foreach (XmlNode drawNode in drawNodes)
            {
                this.Draws.Add(new Draw(drawNode));
            }
        }
    }
}