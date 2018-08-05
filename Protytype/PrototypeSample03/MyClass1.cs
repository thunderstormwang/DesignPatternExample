using System;

namespace Protytype.PrototypeSample03
{
    public class MyClass1 : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
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
            var result = (MyClass2)this.MemberwiseClone();

            //此處深入呼叫 Class1 的 Clone()
            //若是不處理 Data Property 的深層複製，就會出問題
            if (this.Data != null)
            {
                result.Data = (MyClass1)this.Data.Clone();
            }

            return result;
        }
    }
}
