using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TPNetwork
{
    public class XMLBase
    {
        protected virtual XmlElement CreateGroup(XmlDocument document, string id)
        {
            XmlElement group = document.CreateElement("GROUP");
            group.SetAttribute("ID", id);
            return group;
        }

        protected virtual XmlElement CreateItem(XmlDocument document, string id, object val)
        {
            XmlElement item = document.CreateElement("ITEM");
            item.SetAttribute("ID", id);
            if (val is string)
            {
                item.SetAttribute("TYPE", "String");
            }
            else if (val is int)
            {
                item.SetAttribute("TYPE", "Integer");
            }
            else if (val is bool)
            {
                item.SetAttribute("TYPE", "Bool");
            }
            else if (val is float)
            {
                item.SetAttribute("TYPE", "Float");
            }
            else
            {
                throw new NotSupportedException("Item type not supported");
            }
            item.InnerText = val.ToString();
            return item;
        }

        public virtual XmlDocument CreateDocument(string rootVersion = "1.0")
        {
            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("VISUALXML");
            root.SetAttribute("VERSION", rootVersion);
            document.AppendChild(root);
            return document;
        }

        public virtual XmlDocument CreateDocument(List<XmlElement> elements, string rootVersion = "1.0")
        {
            XmlDocument document = CreateDocument(rootVersion);
            XmlElement root = document.DocumentElement;
            elements.ForEach(e => root.AppendChild(e));
            return document;
        }
    }
}
