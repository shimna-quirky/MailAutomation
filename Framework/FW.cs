using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Framework
{
   public  class FW
    {

        public static string WORKSPACE = Path.GetFullPath(@"../../../../");
        public static FwConfig FConfig => _configuration ?? throw new NullReferenceException("Config is null.call SetConfig() first.");
        private static FwConfig _configuration;
        public static void SetConfig()
        {
            var jsonstring = File.ReadAllText(WORKSPACE + "/Framework/Framework-config.json");
            _configuration = JsonConvert.DeserializeObject<FwConfig>(jsonstring);
        }
    }
}
