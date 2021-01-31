using BCA.WerZaehltWo3.Shared.ObjectModel;

namespace BCA.WerZaehltWo3.Tests.Unit
{
    public partial class InitializedObjects
    {
        public static Playerboard CreateNewPlayerboard()
        {
            var result = new Playerboard();
            result.Players.Add("Daniel Hafner");
            result.Players.Add("Anna Anliker / Bobby Bangeter");
            result.Courts.Add(CreateNewCourt());
            return result;
        }
    }
}