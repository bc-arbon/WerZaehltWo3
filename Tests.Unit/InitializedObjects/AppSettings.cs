using BCA.WerZaehltWo3.Shared.ObjectModel;
using System.Drawing;

namespace BCA.WerZaehltWo3.Tests.Unit
{
    public partial class InitializedObjects
    {
        public static AppSettings CreateNewAppSettings()
        {
            var result = new AppSettings
            {
                WindowSize = new Size(123, 456)
            };
            return result;
        }
    }
}