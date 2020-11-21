using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.WerZaehltWo3.Shared.Helpers
{
    public static class JsonHelper
    {
        public static string Save(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);            
        }
        
        public static object Load(string json, Type type)
        {
            var obj = JsonConvert.DeserializeObject(json, type);
            return obj;
        }

        public static void SaveToFile(object obj, string filename)
        {
            File.WriteAllText(filename, Save(obj));
        }

        public static object LoadFromFile(string filename, Type type)
        {
            return Load(File.ReadAllText(filename), type);
        }
    }
}
