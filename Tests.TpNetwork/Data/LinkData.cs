using System.Data;

namespace Tests.TpNetwork.Data
{
    public class LinkData : TpDataObject
    {
        public int ID { get; set; }
        public int SourceDrawID { get; set; }
        public int SourcePosition { get; set; }

        public LinkData() { }

        public LinkData(LinkData cpy)
        {
            ID = cpy.ID;
            SourceDrawID = cpy.SourceDrawID;
            SourcePosition = cpy.SourcePosition;
        }

        public LinkData(IDataReader reader)
        {
            ID = GetInt(reader, "id");
            SourceDrawID = GetInt(reader, "src_draw");
            SourcePosition = GetInt(reader, "src_pos");
        }
    }
}