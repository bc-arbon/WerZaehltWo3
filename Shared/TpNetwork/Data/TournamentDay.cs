using BCA.WerZaehltWo3.Shared.Helpers;
using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class TournamentDay
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public static TournamentDay Parse(XmlNode node)
        {
            var tournamentDay = new TournamentDay();
            tournamentDay.Id = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            tournamentDay.Date = VisualXmlHelpers.GetDateTime(node.SelectSingleNode("ITEM[@ID='Date']/DATETIME"));
            return tournamentDay;
        }
    }
}
