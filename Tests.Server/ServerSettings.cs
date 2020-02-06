using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.Tests.Server.Adapters
{
    public class ServerSettings
    {
        public ServerSettings()
        {
            Debug = false;
        }

        public string ServerAddress { get; set; }

        public int Port { get; set; }

        public string DatabaseFilepath { get; set; }

        public string Adapter { get; set; }

        public bool Debug { get; set; }
    }
}
