using BCA.WerZaehltWo3.ObjectModel;
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

        public List<Player> GetPlayers()
        {
            var player1 = new Player { Name = "Hans Nötig", Id = "123456", Club = "BC Arbon", Category = "Kn U12" };
            var player2 = new Player { Name = "Guschti Brösmeli", Id = "273672", Club = "BC Hintertupfigen", Category = "Kn Stk1" };
            var player3 = new Player { Name = "Peter Müller", Id = "272718", Club = "BC Chapf", Category = "Mä Stk3" };
            return new List<Player> { player1, player2, player3 };
        }
    }
}
