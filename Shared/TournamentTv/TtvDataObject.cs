using System;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TournamentTv
{
    public abstract class TtvDataObject
    {
        protected static int GetInt(XmlNode node, string fieldName)
        {
            return node.Attributes[fieldName] != null ? Convert.ToInt32(node.Attributes[fieldName].Value) : int.MinValue;
        }

        protected static string GetString(XmlNode node, string fieldName)
        {
            return node.Attributes[fieldName]?.Value;
        }

        protected static DateTime GetDateTime(XmlNode node, string fieldName)
        {
            return node.Attributes[fieldName] != null ? Convert.ToDateTime(node.Attributes[fieldName].Value) : DateTime.MinValue;
        }

        protected static bool GetBool(XmlNode node, string fieldName)
        {
            if (node.Attributes[fieldName] != null)
            {
                var parsed = GetInt(node, fieldName);
                return Convert.ToBoolean(parsed);
            }
            else
            {
                return false;
            }
        }
    }
}