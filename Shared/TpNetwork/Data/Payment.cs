using BCA.WerZaehltWo3.Shared.Helpers;
using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TpNetwork.Data
{
    public class Payment
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentType { get; set; }
        public int PlayerID { get; set; }

        public static Payment Parse(XmlNode node)
        {
            var payment = new Payment();
            payment.ID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='ID']").InnerText);
            payment.PlayerID = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='PlayerID']").InnerText);
            payment.Amount = Convert.ToDouble(node.SelectSingleNode("ITEM[@ID='Amount']").InnerText);
            payment.PaymentDate = VisualXmlHelpers.GetDateTime(node.SelectSingleNode("ITEM[@ID='PaymentDate']/DATETIME"));
            payment.PaymentType = Convert.ToInt32(node.SelectSingleNode("ITEM[@ID='PaymentType']").InnerText);
            return payment;
        }
    }
}
