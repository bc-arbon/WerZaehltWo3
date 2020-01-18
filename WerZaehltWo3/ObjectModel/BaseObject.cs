namespace BCA.WerZaehltWo3.ObjectModel
{
    using System.Xml;
    
    public class BaseObject
    {
        public virtual void Load(XmlNode node)
        {
        }

        public virtual string Save()
        {
            return string.Empty;
        }

        public virtual void Clear()
        {
        }
    }
}