using System;

namespace FactoryMethodSample002
{
    /// <summary>
    /// 搭配 Template Method
    /// </summary>
    public abstract class Factory
    {
        protected abstract Type RealType { get; }

        public ICommunication GetInstance()
        {
            return (ICommunication)Activator.CreateInstance(RealType);
        }
    }
}