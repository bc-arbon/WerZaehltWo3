namespace BCA.WerZaehltWo3.ObjectModel
{
    using System.Xml;
    
    public class BaseObject
    {
        /// <summary>
        /// Loads this instance.
        /// </summary>
        /// <param name="node">The node.</param>
        public virtual void Load(XmlNode node)
        {
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns>Xml string</returns>
        public virtual string Save()
        {
            return string.Empty;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public virtual void Clear()
        {
        }
    }
}