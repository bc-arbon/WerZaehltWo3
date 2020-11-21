using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Tests.Unit
{
    public partial class InitializedObjects
    {
        public static PlayerSet CreateNewPlayerSet()
        {
            return new PlayerSet { Player1 = CreateNewPlayer(), Player2 = CreateNewPlayer2() };
        }
    }
}