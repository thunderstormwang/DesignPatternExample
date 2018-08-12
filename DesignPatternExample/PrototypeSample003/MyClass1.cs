using System;

namespace ProtytypeSample003
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
}