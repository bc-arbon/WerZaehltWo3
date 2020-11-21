using Newtonsoft.Json;
using System.IO;

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
