using Newtonsoft.Json;
using System.IO;

namespace TsDataServer
{
    public class AppSettings
    {
        public static string Filename = "server.config";

        public string DatabaseFilePath { get; set; }
        public bool RabbitEnabled { get; set; }
        public string RabbitServer { get; set; }
        public string RabbitUser { get; set; }
        public string RabbitPassword { get; set; }
        public string RabbitVhost { get; set; }
        public bool JsonEnabled { get; set; }
        public string JsonFilePath { get; set; }
        public int Interval { get; set; }

        public static AppSettings LoadFromFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<AppSettings>(json);
        }

        public static void SaveToFile(string filePath, AppSettings appSettings)
        {
            var json = JsonConvert.SerializeObject(appSettings, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
