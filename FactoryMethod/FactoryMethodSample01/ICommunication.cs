namespace FactoryMethodSample01
{
    /// <summary>
    /// 這就是一個 Target
    /// </summary>
    public interface ICommunication
    {
        bool Connect(string target);

        void Disconnect();

        void Send(byte[] buffer);

        byte[] Receive();
    }
}