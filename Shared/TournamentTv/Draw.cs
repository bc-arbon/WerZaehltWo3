using System.Collections.Generic;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class Draw : TtvDataObject
    {
        public int Id { get; set; }
        public DrawType DrawType { get; set; }
        public int DrawSize { get; set; }
        public int DrawEndSize { get; set; }
        public string Name { get; set; }
        public string DrawName { get; set; }
        public string Columns { get; set; }
        public bool Doubles { get; set; }
        public bool Playoff { get; set; }
        public int EventId { get; set; }
        public int StageId { get; set; }
        public int Position { get; set; }
        public List<DrawMatch> Matches { get; set; } = new List<DrawMatch>();
        public List<Entry> Entries { get; set; } = new List<Entry>();
        public List<Standing> Standings { get; set; } = new List<Standing>();

        public Draw(XmlNode node)
        {
            this.Id = GetInt(node, "ID");
            this.DrawType = (DrawType)GetInt(node, "DRAWTYPE");
            this.DrawSize = GetInt(node, "DRAWSIZE");
            this.DrawEndSize = GetInt(node, "DRAWENDSIZE");
            this.Name = GetString(node, "NAME");
            this.DrawName = GetString(node, "DRAWNAME");
            this.Columns = GetString(node, "COLUMNS");
            this.Doubles = GetBool(node, "DOUBLES");
            this.Playoff = GetBool(node, "PLAYOFF");
            this.EventId = GetInt(node, "EVENT");
            this.StageId = GetInt(node, "STAGEID");
            this.Position = GetInt(node, "POSITION");

            var matchNodes = node.SelectNodes("MATCHES/MATCH");
            foreach (XmlNode matchNode in matchNodes)
            {
                this.Matches.Add(new DrawMatch(matchNode));
            }

            var entryNodes = node.SelectNodes("ENTRIES/ENTRY");
            foreach (XmlElement entryNode in entryNodes)
            {
                this.Entries.Add(new Entry(entryNode));
            }

            var standingNodes = node.SelectNodes("STANDINGS/STANDING");
            foreach (XmlElement standingNode in standingNodes)
            {
                this.Standings.Add(new Standing(standingNode));
            }
        }
    }
}