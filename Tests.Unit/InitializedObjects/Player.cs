namespace BCA.WerZaehltWo3.Tests.Unit
{
    using BCA.WerZaehltWo3.ObjectModel;

    public partial class InitializedObjects
    {
        public static Player CreateNewPlayer()
        {
            return new Player { Club = "BC Arbon", Name = "Daniel Hafner", Category = "U25", Id = "blubb" };
        }

        public static Player CreateNewPlayer2()
        {
            return new Player { Club = "BC Wittenbach", Name = "Simon Mäder", Category = "U25", Id = "blubb" };
        }
    }
}