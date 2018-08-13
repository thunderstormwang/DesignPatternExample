using Newtonsoft.Json;

namespace PrototypeSample007_Extension
{
    public class PrototypeExtension
    {
        public static T Clone<T>(T source) where T : class, new()
        {
            T result = new T();
            var json = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}