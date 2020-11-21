using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Tests.Unit
{
    public partial class InitializedObjects
    {
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