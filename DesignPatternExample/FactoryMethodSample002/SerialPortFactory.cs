using System;

namespace FactoryMethodSample002
{
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