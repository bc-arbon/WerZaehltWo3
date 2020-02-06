using BCA.WerZaehltWo3.ObjectModel;
using System.Collections.Generic;

namespace BCA.WerZaehltWo3.Tests.Server.Adapters
{
    public interface IAdapter
    {
        void Connect(string databaseFilepath);

        void Close();

        List<Player> GetPlayers();
    }
}
