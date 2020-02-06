using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.Tests.Server.Adapters
{
    public class SettingsProvider
    {
        public ServerSettings Settings { get; private set; }

        public SettingsProvider()
        {
            var file = "config.json";
            this.Settings = JsonConvert.DeserializeObject<ServerSettings>(File.ReadAllText(file));
        }
    }
}
