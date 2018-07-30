namespace AdapterExample
{
    public interface ICommunication
    {
        bool Connect(string target);

        void Disconnect();

        void Send(byte[] buffer);

        byte[] Receive();
    }
}