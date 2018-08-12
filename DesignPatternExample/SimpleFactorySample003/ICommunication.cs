namespace SimpleFactorySample003
{
    /// <summary>
    /// 這就是一個 Target
    /// </summary>
    public interface ICommunication
    {
        bool Connect(string target);

        void Disconnect();

        // 被迫改名
        void SendData(byte[] buffer);

        byte[] ReceiveData();
    }
}