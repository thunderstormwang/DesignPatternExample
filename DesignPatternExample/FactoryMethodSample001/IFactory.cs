namespace FactoryMethodSample001
{
    public interface IFactory
    {
        ICommunication GetInstance();
    }
}