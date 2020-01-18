namespace BCA.WerZaehltWo3.Tests.Unit
{
    using BCA.WerZaehltWo3.ObjectModel;
    
    public partial class InitializedObjects
    {
        public static PlayerSet CreateNewPlayerSet()
        {
            return new PlayerSet { Player1 = CreateNewPlayer(), Player2 = CreateNewPlayer2() };
        }
    }
}