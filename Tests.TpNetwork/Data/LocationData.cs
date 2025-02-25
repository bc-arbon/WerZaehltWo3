using System.Data;

namespace Tests.TpNetwork.Data
{
    public class LocationData : TpDataObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public LocationData(IDataReader reader)
        {
            ID = GetInt(reader, "id");
            Name = GetString(reader, "name");
        }
    }
}