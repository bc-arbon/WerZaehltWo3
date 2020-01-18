namespace BCA.WerZaehltWo3.Tests.Unit
{
    using BCA.WerZaehltWo3.ObjectModel;

    public partial class InitializedObjects
    {
        /// <summary>
        /// Creates the new player.
        /// </summary>
        /// <returns>new Player</returns>
        public static Playerboard CreateNewPlayerboard()
        {
            var result = new Playerboard();
            result.Players.Add(CreateNewPlayer());
            result.Players.Add(CreateNewPlayer2());
            result.Courts.Add(CreateNewCourt());
            return result;
        }
    }
}