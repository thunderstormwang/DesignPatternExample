namespace FactoryMethodSample001
{
    public class SerialPortFactory : IFactory
    {
        public ICommunication GetInstance()
        {
            return new SerialCommunication();
        }
    }
}