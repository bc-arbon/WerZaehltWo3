using System.Data;
using System.Xml;

namespace Tests.TpNetwork.Data
{
    public class DrawData : TpDataObject
    {
        public enum DrawTypes
        { 
            PlayOffCup = 1, 
            RoundRobin = 2, 
            QualifierCups = 6,
            Schoch = 17
        }

        public int Id { get; set; }
        public DrawTypes DrawType { get; set; }
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

        public DrawData() { }

        public DrawData(DrawData cpy)
        {
            Id = cpy.Id;
            Name = cpy.Name;
            DrawType = cpy.DrawType;
            EventId = cpy.EventId;
            DrawEndSize = cpy.DrawEndSize;
        }

        public DrawData(IDataReader reader)
        {
            Id = GetInt(reader, "id");
            Name = GetString(reader, "name");
            DrawType = (DrawTypes)GetInt(reader, "drawType");
            EventId = GetInt(reader, "event");
            DrawEndSize = GetInt(reader, "drawendsize");
        }

        public DrawData(XmlReader reader)
        {
            Id = GetInt(reader, "ID");
            Name = GetString(reader, "DRAWNAME");
            DrawType = (DrawTypes)GetInt(reader, "DRAWTYPE");
            EventId = GetInt(reader, "EVENT");
            DrawEndSize = GetInt(reader, "DRAWENDSIZE");
        }

        public DrawData(XmlNode node)
        {
            Id = GetInt(node, "ID");
            DrawType = (DrawTypes)GetInt(node, "DRAWTYPE");
            DrawEndSize = GetInt(node, "DRAWSIZE");
            DrawEndSize = GetInt(node, "DRAWENDSIZE");
            Name = GetString(node, "NAME");
            DrawName = GetString(node, "DRAWNAME");
            Columns = GetString(node, "COLUMNS");
            Doubles = GetBool(node, "DOUBLES");
            Doubles = GetBool(node, "PLAYOFF");
            EventId = GetInt(node, "EVENT");
            StageId = GetInt(node, "STAGE");
            Position = GetInt(node, "POSITION");
        }
    }
}