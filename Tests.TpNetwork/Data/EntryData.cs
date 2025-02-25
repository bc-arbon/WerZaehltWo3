using System.Data;
using System.Xml;

namespace Tests.TpNetwork.Data
{
    public class EntryData : TpDataObject
    {
        public int Id { get; set; }
        public int Seed { get; set; }
        public int Rank { get; set; }
        public string Name1 { get; set; }
        public string ShortName1 { get; set; }
        public int MemberId1 { get; set; }
        public string Name2 { get; set; }
        public string ShortName2 { get; set; }
        public int MemberId2 { get; set; }
        public string Club1 { get; set; }
        public string Club2 { get; set; }
        public string Country1 { get; set; }
        public int Flag1 { get; set; }
        public string Country2 { get; set; }
        public int Flag2 { get; set; }

        public EntryData() { }

        public EntryData(EntryData cpy)
        {
            Id = cpy.Id;
            MemberId1 = cpy.MemberId1;
            MemberId2 = cpy.MemberId2;
        }

        public EntryData(IDataReader reader)
        {
            Id = GetInt(reader, "id");
            MemberId1 = GetInt(reader, "player1");
            MemberId2 = GetInt(reader, "player2");
        }

        public EntryData(XmlReader reader)
        {
            Id = GetInt(reader, "ID");
            
        }

        public EntryData(XmlNode node)
        {
            Id = GetInt(node, "ID");
            Seed = GetInt(node, "SEED");
            Rank = GetInt(node, "RANK");
            Name1 = GetString(node, "NAME1");
            ShortName1 = GetString(node, "SHORTNAME1");
            MemberId1 = GetInt(node, "MEMBERID1");
            Name2 = GetString(node, "NAME2");
            ShortName2 = GetString(node, "SHORTNAME2");
            MemberId2 = GetInt(node, "MEMBERID2");
            Club1 = GetString(node, "CLUB1");
            Club2 = GetString(node, "CLUB2");
            Country1 = GetString(node, "COUNTRY1");
            Flag1 = GetInt(node, "FLAG1");
            Country2 = GetString(node, "COUNTRY2");
            Flag2 = GetInt(node, "FLAG2");
        }
    }
}