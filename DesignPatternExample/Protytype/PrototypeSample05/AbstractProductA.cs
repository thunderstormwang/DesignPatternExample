using System;

namespace Protytype.PrototypeSample05
{
    public abstract class AbstractProductA : ICloneable
    {
        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    internal class ProductA1 : AbstractProductA
    { }

    internal class ProductA2 : AbstractProductA
    { }
}
