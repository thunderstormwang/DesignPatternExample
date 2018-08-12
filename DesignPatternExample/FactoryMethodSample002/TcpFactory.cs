using System;

namespace FactoryMethodSample002
{
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
}