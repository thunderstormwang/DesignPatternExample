namespace FactoryMethodSample01
{
    public interface IFactory
    {
        ICommunication GetInstance();
    }

    public class TcpFactory : IFactory
    {
        public ICommunication GetInstance()
        {
            return new TcpCommunication();
        }
    }

    public class SerialPortFactory : IFactory
    {
        public ICommunication GetInstance()
        {
            return new SerialCommunication();
        }
    }
}