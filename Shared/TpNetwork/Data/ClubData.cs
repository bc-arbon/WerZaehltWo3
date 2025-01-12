using System.Data;

namespace BCA.WerZaehltWo3.Shared.TPNetwork.Data
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