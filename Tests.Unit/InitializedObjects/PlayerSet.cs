namespace BCA.WerZaehltWo3.Tests.Unit
{
    using BCA.WerZaehltWo3.ObjectModel;
    
    public partial class InitializedObjects
    {
        /// <summary>
        /// Creates the new player.
        /// </summary>
        /// <returns>new Player</returns>
        public static PlayerSet CreateNewPlayerSet()
        {
            return new PlayerSet { Player1 = CreateNewPlayer(), Player2 = CreateNewPlayer2() };
        }
    }
}