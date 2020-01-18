namespace BCA.WerZaehltWo3.Tests.Unit
{
    using BCA.WerZaehltWo3.ObjectModel;

    public partial class InitializedObjects
    {
        /// <summary>
        /// Creates the new player.
        /// </summary>
        /// <returns>new Player</returns>
        public static Court CreateNewCourt()
        {
            var result = new Court { Number = 27 };
            result.PlayersReady.CopyFrom(CreateNewPlayerSet());
            result.PlayersCount.CopyFrom(CreateNewPlayerSet());
            result.PlayersPlay.CopyFrom(CreateNewPlayerSet());
            return result;
        }
    }
}