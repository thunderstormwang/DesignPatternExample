using Newtonsoft.Json;

namespace Facade
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
