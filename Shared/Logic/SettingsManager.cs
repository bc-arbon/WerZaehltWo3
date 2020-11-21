using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using System.IO;

namespace BCA.WerZaehltWo3.Shared.Logic
{
    public class SettingsManager
    {
        public AppSettings AppSettings { get; private set; }

        public void Save()
        {
            JsonHelper.SaveToFile(this.AppSettings, Constants.AppSettingsFilename);
        }

        public void Load()
        {
            if (!File.Exists(Constants.AppSettingsFilename))
            {
                // Do nothing, when the file is not present
                this.AppSettings = new AppSettings();
                return;
            }

            
            this.AppSettings = (AppSettings)JsonHelper.LoadFromFile(Constants.AppSettingsFilename, typeof(AppSettings));            
        }
    }
}