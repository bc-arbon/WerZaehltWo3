using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TpNetwork.Data
{
    public class PlayerData : TpDataObject
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int ClubID { get; set; }
        public int CountryID { get; set; }

        public PlayerData() { }

        public PlayerData(PlayerData cpy)
        {
            ID = cpy.ID;
            LastName = cpy.LastName;
            FirstName = cpy.FirstName;
            ClubID = cpy.ClubID;
            CountryID = cpy.CountryID;
        }

        public PlayerData(IDataReader reader)
        {
            ID = GetInt(reader, "id");
            LastName = GetString(reader, "name");
            FirstName = GetString(reader, "firstname");
            ClubID = GetInt(reader, "club");
            CountryID = GetInt(reader, "country");
        }
    }
}