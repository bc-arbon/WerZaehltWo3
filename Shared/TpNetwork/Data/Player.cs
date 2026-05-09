using BCA.WerZaehltWo3.Shared.Helpers;
using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Player
    {
        public int ID { get; set; }
        public int ClubID { get; set; }
        public int MemberID {  get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }        
        public string PhoneHome { get; set; }
        public string Mobile { get; set; }
        public int GenderID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Asianname { get; set; }
        public bool CheckedIn { get; set; }
        public bool FirstCheckIn { get; set; }
        public int BackNr { get; set; }
        public DateTime LastTimeOnCourt { get; set; }
        public bool WeightChecked { get; set; }
        public double EntryWeight { get; set; }
        public double Weight { get; set; }
        public double Weight2 { get; set; }
        public double Discount { get; set; }

        public static Player Parse(XmlNode node)
        {
            var player = new Player();
            player.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            player.ClubID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ClubID']").InnerText);
            player.MemberID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='MemberID']").InnerText);
            player.Lastname = node.SelectSingleNode("ITEM[@ID='Lastname']").InnerText;
            player.Firstname = node.SelectSingleNode("ITEM[@ID='Firstname']").InnerText;
            player.Email = node.SelectSingleNode("ITEM[@ID='Email']").InnerText;
            player.Country = node.SelectSingleNode("ITEM[@ID='Country']").InnerText;
            player.ClubID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ClubID']").InnerText);
            player.PhoneHome = node.SelectSingleNode("ITEM[@ID='PhoneHome']")?.InnerText;
            player.Mobile = node.SelectSingleNode("ITEM[@ID='Mobile']")?.InnerText;
            player.GenderID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='GenderID']").InnerText);
            player.DateOfBirth = VisualXmlHelpers.GetDateTime(node.SelectSingleNode("ITEM[@ID='DateOfBirth']/DATETIME"));
            player.Asianname = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='Asianname']").InnerText);
            player.CheckedIn = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='CheckedIn']").InnerText);
            player.FirstCheckIn = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='FirstCheckIn']").InnerText);
            player.BackNr = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='BackNr']").InnerText);
            player.LastTimeOnCourt = VisualXmlHelpers.GetDateTime(node.SelectSingleNode("ITEM[@ID='LastTimeOnCourt']/DATETIME"));
            player.WeightChecked = Convert.ToBoolean(node.SelectSingleNode("ITEM[@ID='WeightChecked']").InnerText);
            player.EntryWeight = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='EntryWeight']").InnerText);
            player.Weight = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='Weight']").InnerText);
            player.Weight2 = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='Weight2']").InnerText);
            player.Discount = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='Discount']").InnerText);
            return player;
        }

    }
}
