using Newtonsoft.Json;

namespace PrototypeSample007_Extension
{
    public static class PrototypeExtension
    {
        public static T Clone<T>(this T source) where T : class, new()
        {
            T result = new T();
            var json = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}