namespace BCA.WerZaehltWo3.Tests.Unit
{
    using BCA.WerZaehltWo3.ObjectModel;

    public partial class InitializedObjects
    {
        /// <summary>
        /// Creates the new player.
        /// </summary>
        /// <returns>new Player</returns>
        public static Player CreateNewPlayer()
        {
            return new Player { Club = "BC Arbon", Name = "Daniel Hafner", Category = "U25", Id = "blubb" };
        }

        /// <summary>
        /// Creates the new player.
        /// </summary>
        /// <returns>new Player</returns>
        public static Player CreateNewPlayer2()
        {
            return new Player { Club = "BC Wittenbach", Name = "Simon Mäder", Category = "U25", Id = "blubb" };
        }
    }
}