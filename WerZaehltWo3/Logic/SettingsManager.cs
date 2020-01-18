using BCA.WerZaehltWo3.Common;
using BCA.WerZaehltWo3.ObjectModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BCA.WerZaehltWo3.Logic
{
    public class SettingsManager
    {
        public AppSettings AppSettings { get; } = new AppSettings();

        public void Save()
        {
            var xmlString = this.AppSettings.Save();

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);
            doc.Save(Constants.AppSettingsFilename);
        }

        public void Load()
        {
            if (!File.Exists(Constants.AppSettingsFilename))
            {
                // Do nothing, when the file is not present
                return;
            }

            var doc = new XmlDocument();
            doc.Load(Constants.AppSettingsFilename);

            var node = doc.SelectSingleNode("AppSettings");
            if (node != null)
            {
                this.AppSettings.Load(node);
            }
        }
    }
}