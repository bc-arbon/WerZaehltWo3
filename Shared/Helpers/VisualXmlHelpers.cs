using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.Helpers
{
    public static class VisualXmlHelpers
    {
        public static DateTime GetDateTime(XmlNode node)
        {
            if (node == null)
            {
                return DateTime.MinValue;
            }

            var year = Convert.ToInt32(node.Attributes["Y"].Value);
            var month = Convert.ToInt32(node.Attributes["MM"].Value);
            var day = Convert.ToInt32(node.Attributes["D"].Value);
            var hour = Convert.ToInt32(node.Attributes["H"].Value);
            var minute = Convert.ToInt32(node.Attributes["M"].Value);
            var seconds = Convert.ToInt32(node.Attributes["S"].Value);

            return new DateTime(year, month, day, hour, minute, seconds);
        }
    }
}
