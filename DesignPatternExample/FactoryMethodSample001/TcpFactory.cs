namespace FactoryMethodSample001
{
    public class TcpFactory : IFactory
    {
        public ICommunication GetInstance()
        {
            return new TcpCommunication();
        }
    }
}