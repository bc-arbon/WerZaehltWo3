using System.Data;

namespace Tests.TpNetwork.Data
{
    public class ClubData : TpDataObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ClubData()
        {
        }

        public ClubData(IDataReader reader)
        {
            ID = GetInt(reader, "id");
            Name = GetString(reader, "name");
        }
    }
}