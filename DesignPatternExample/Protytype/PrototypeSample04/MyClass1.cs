using Newtonsoft.Json;
using System;

namespace Protytype.PrototypeSample04
{
    public class MyClass1
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class MyClass2 : ICloneable
    {
        public MyClass1 Data { get; set; }
        public string Id { get; set; }

        public MyClass2()
        {
            Data = new MyClass1();
        }

        public object Clone()
        {
            var json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<MyClass2>(json);
        }
    }
}
