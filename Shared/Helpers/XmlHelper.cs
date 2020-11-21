//namespace BCA.WerZaehltWo3.Shared.Helpers
//{
//    using System;
//    using System.Globalization;
//    using System.Xml;

//    public static class XmlHelper
//    {
//        public static string SaveAttribute(string name, string value)
//        {
//            if (name == null) throw new ArgumentNullException("name");

//            return name + "=\"" + (value ?? string.Empty) + "\"";
//        }

//        public static string SaveAttribute(string name, int value)
//        {
//            return SaveAttribute(name, value.ToString(CultureInfo.InvariantCulture));
//        }

//        public static string LoadAttribute(XmlNode node, string name, string defaultValue)
//        {
//            if (node.Attributes != null)
//            {
//                if (node.Attributes[name] != null)
//                {
//                    if (!string.IsNullOrEmpty(node.Attributes[name].Value))
//                    {
//                        return node.Attributes[name].Value;
//                    }

//                    return defaultValue;
//                }

//                return defaultValue;
//            }

//            return defaultValue;
//        }

//        public static int LoadAttribute(XmlNode node, string name, int defaultValue)
//        {
//            var value = LoadAttribute(node, name, defaultValue.ToString(CultureInfo.InvariantCulture));
//            if (!string.IsNullOrEmpty(value))
//            {
//                return Convert.ToInt32(value);
//            }

//            return defaultValue;
//        }
//    }
//}