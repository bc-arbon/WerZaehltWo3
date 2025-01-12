using BCA.WerZaehltWo3.Shared.TPNetwork.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BCA.WerZaehltWo3.Shared.TPNetwork.Models
{
    public class Court : CourtData
    {
        public LocationData Location { get; set; }
        protected Court(CourtData raw, LocationData location) : base(raw)
        {
            Location = location;
        }
        public static Court Parse(CourtData raw, IEnumerable<LocationData> locations)
        {
            var location = locations.First(loc => loc.ID == raw.LocationID);
            if (location == null)
            {
                throw new Exception("Court location not specified or found.");
            }

            return new Court(raw, location);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Location.Name);
        }
    }
}