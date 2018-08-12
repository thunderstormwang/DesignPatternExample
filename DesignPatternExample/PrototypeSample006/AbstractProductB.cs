using System;

namespace ProtytypeSample006
{
    public abstract class AbstractProductB : ICloneable
    {
        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    internal class ProductB1 : AbstractProductB
    { }

    internal class ProductB2 : AbstractProductB
    { }
}