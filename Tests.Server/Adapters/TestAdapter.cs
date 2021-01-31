using System;
using System.Collections.Generic;

namespace BCA.WerZaehltWo3.Tests.Server.Adapters.Adapters
{
    public class TestAdapter : IAdapter
    {
        public void Close()
        {
            Console.WriteLine("Close was called");
        }

        public void Connect(string databaseFilepath)
        {
            Console.WriteLine("Connect was called with param " + databaseFilepath);
        }

        public List<string> GetPlayers()
        {
            return new List<string> { "Hans Nötig", "Guschti Brösmeli", "Peter Müller" };
        }
    }
}
