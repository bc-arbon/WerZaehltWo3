using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BCA.WerZaehltWo3.Shared.TPNetwork
{
    public class SendTournamentInfoRequest : XMLBase
    {
        public string MessageID { get; } = "SENDTOURNAMENTINFO";
        public string Password { get; set; }
        public IPAddress IP { get; set; }
        public (int low, int high) Version { get; set; } = (1, 1);
        public string Unicode { get; set; } = "202201171939355343";

        public List<XmlElement> CreateElements(XmlDocument document)
        {
            List<XmlElement> elements = new List<XmlElement>();

            XmlElement headerGroup = CreateGroup(document, "Header");
            XmlElement versionGroup = CreateGroup(document, "Version");
            versionGroup.AppendChild(CreateItem(document, "Hi", Version.high));
            versionGroup.AppendChild(CreateItem(document, "Lo", Version.low));
            headerGroup.AppendChild(versionGroup);
            elements.Add(headerGroup);

            XmlElement actionGroup = CreateGroup(document, "Action");
            actionGroup.AppendChild(CreateItem(document, "ID", MessageID));
            actionGroup.AppendChild(CreateItem(document, "Password", Password));
            actionGroup.AppendChild(CreateItem(document, "Unicode", Unicode));
            elements.Add(actionGroup);

            XmlElement clientGroup = CreateGroup(document, "Client");
            clientGroup.AppendChild(CreateItem(document, "IP", IP.ToString()));
            elements.Add(clientGroup);

            return elements;
        }

        public override XmlDocument CreateDocument(string rootVersion = "1.0")
        {
            XmlDocument document = base.CreateDocument(rootVersion);
            XmlElement root = document.DocumentElement;
            CreateElements(document).ForEach(e => root.AppendChild(e));
            return document;
        }

    }
}
