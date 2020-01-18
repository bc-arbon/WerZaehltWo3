namespace BCA.WerZaehltWo3.Common
{
    using System;
    using System.Globalization;
    using System.Xml;

    /// <summary>
    /// XmlHelper class
    /// </summary>
    public static class XmlHelper
    {
        /// <summary>
        /// Saves the attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns>xml attribute</returns>
        public static string SaveAttribute(string name, string value)
        {
            if (name == null) throw new ArgumentNullException("name");

            return name + "=\"" + (value ?? string.Empty) + "\"";
        }

        /// <summary>
        /// Saves the attribute.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns>xml attribute</returns>
        public static string SaveAttribute(string name, int value)
        {
            return SaveAttribute(name, value.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Loads the attribute.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>attribute value as string</returns>
        public static string LoadAttribute(XmlNode node, string name, string defaultValue)
        {
            if (node.Attributes != null)
            {
                if (node.Attributes[name] != null)
                {
                    if (!string.IsNullOrEmpty(node.Attributes[name].Value))
                    {
                        return node.Attributes[name].Value;
                    }

                    return defaultValue;
                }

                return defaultValue;
            }

            return defaultValue;
        }

        /// <summary>
        /// Loads the attribute.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="name">The name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>attribute value as int</returns>
        public static int LoadAttribute(XmlNode node, string name, int defaultValue)
        {
            var value = LoadAttribute(node, name, defaultValue.ToString(CultureInfo.InvariantCulture));
            if (!string.IsNullOrEmpty(value))
            {
                return Convert.ToInt32(value);
            }

            return defaultValue;
        }
    }
}