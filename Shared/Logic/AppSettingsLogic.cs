using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using System.IO;

namespace BCA.WerZaehltWo3.Shared.Logic
{
    public static class AppSettingsLogic
    {
        public static void Save(AppSettings settings)
        {
            JsonHelper.SaveToFile(settings, Constants.AppSettingsFilename);
        }

        public static AppSettings Load()
        {
            if (!File.Exists(Constants.AppSettingsFilename))
            {
                // Do nothing, when the file is not present
                return new AppSettings();
            }

            
            var settings = (AppSettings)JsonHelper.LoadFromFile(Constants.AppSettingsFilename, typeof(AppSettings));
            return settings;
        }
    }
}