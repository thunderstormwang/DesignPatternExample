using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample02
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

    public class TcpFactory : Factory
    {
        protected override Type RealType
        {
            get
            {
                return typeof(TcpCommunication);
            }
        }
    }

    public class SerialPortFactory : Factory
    {
        protected override Type RealType
        {
            get
            {
                return typeof(SerialCommunication);
            }
        }
    }
}
