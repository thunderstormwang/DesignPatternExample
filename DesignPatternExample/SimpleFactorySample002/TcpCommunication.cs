using System;

namespace SimpleFactorySample002
{
    /// <summary>
    /// Tcp Adapter, 虛擬碼
    /// </summary>
    public class TcpCommunication : ICommunication
    {
        public bool Connect(string target)
        {
            Console.WriteLine(string.Format("Tcp 連接到 : {0} ", target));
            return true;
        }

        public void Disconnect()
        {
            Console.WriteLine("Tcp 連接關閉");
        }

        public byte[] ReceiveData()
        {
            byte[] result = new byte[] { 0x11, 0x12, 0x13, 0x14 };
            return result;
        }

        public void SendData(byte[] buffer)
        {
            string data = BitConverter.ToString(buffer);
            Console.WriteLine(string.Format("Tcp 送出 : {0} ", data));
        }
    }
}