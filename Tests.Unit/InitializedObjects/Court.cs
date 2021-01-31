using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Tests.Unit
{
    public partial class InitializedObjects
    {
        public static Court CreateNewCourt()
        {
            var result = new Court { Number = 27 };
            result.PlayerReady1 = "Player Ready 1";
            result.PlayerReady2 = "Player Ready 2";
            result.PlayerCount1 = "Player Count 1";
            result.PlayerCount2 = "Player Count 2";
            result.PlayerPlay1 = "Player Play 1";
            result.PlayerPlay2 = "Player Play 2";
            return result;
        }
    }
}