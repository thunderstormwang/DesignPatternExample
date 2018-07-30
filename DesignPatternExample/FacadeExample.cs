using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    public class MyJsonConver
    {
        public static string Serialize(object source)
        {
            return JsonConvert.SerializeObject(source);
        }

        public static T DeserializeObject<T>(string source)
        {
            return JsonConvert.DeserializeObject<T>(source);
        }
    }
}
