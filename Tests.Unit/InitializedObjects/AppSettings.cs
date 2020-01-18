namespace BCA.WerZaehltWo3.Tests.Unit
{
    using BCA.WerZaehltWo3.ObjectModel;
    using System.Drawing;

    public partial class InitializedObjects
    {
        public static AppSettings CreateNewAppSettings()
        {
            var result = new AppSettings();
            result.WindowSize = new Size(123, 456);
            return result;
        }
    }
}