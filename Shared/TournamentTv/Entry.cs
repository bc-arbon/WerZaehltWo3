using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public class Entry : TtvDataObject
    {
        public int Id { get; set; }
        public string Seed { get; set; }
        public int Rank { get; set; }
        public string Name1 { get; set; }
        public string ShortName1 { get; set; }
        public string MemberId1 { get; set; }
        public string Name2 { get; set; }
        public string ShortName2 { get; set; }
        public string MemberId2 { get; set; }
        public string Name3 { get; set; }
        public string ShortName3 { get; set; }
        public string MemberId3 { get; set; }
        public string Name4 { get; set; }
        public string ShortName4 { get; set; }
        public string MemberId4 { get; set; }
        public string Club1 { get; set; }
        public string Club2 { get; set; }
        public string Country1 { get; set; }
        public int Flag1 { get; set; }
        public string Country2 { get; set; }
        public int Flag2 { get; set; }

        public Entry(XmlNode node)
        {
            this.Id = GetInt(node, "ID");
            this.Seed = GetString(node, "SEED");
            this.Rank = GetInt(node, "RANK");
            this.Name1 = GetString(node, "NAME1");
            this.ShortName1 = GetString(node, "SHORTNAME1");
            this.MemberId1 = GetString(node, "MEMBERID1");
            this.Name2 = GetString(node, "NAME2");
            this.ShortName2 = GetString(node, "SHORTNAME2");
            this.MemberId2 = GetString(node, "MEMBERID2");
            this.Name3 = GetString(node, "NAME3");
            this.ShortName3 = GetString(node, "SHORTNAME3");
            this.MemberId3 = GetString(node, "MEMBERID3");
            this.Name4 = GetString(node, "NAME4");
            this.ShortName4 = GetString(node, "SHORTNAME4");
            this.MemberId4 = GetString(node, "MEMBERID4");

            this.Club1 = GetString(node, "CLUB1");
            this.Club2 = GetString(node, "CLUB2");
            this.Country1 = GetString(node, "COUNTRY1");
            this.Flag1 = GetInt(node, "FLAG1");
            this.Country2 = GetString(node, "COUNTRY2");
            this.Flag2 = GetInt(node, "FLAG2");
        }
    }
}