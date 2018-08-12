using System;

namespace FactoryMethodSample002
{
    /// <summary>
    /// Serialport Adapter, 虛擬碼
    /// </summary>
    public class SerialCommunication : ICommunication
    {
        public bool Connect(string target)
        {
            Console.WriteLine(string.Format("開啟 Serial Port : {0} ", target));
            return true;
        }

        public void Disconnect()
        {
            Console.WriteLine("關閉 Serial Port");
        }

        public byte[] Receive()
        {
            byte[] result = new byte[] { 0x01, 0x02, 0x03, 0x04 };
            return result;
        }

        public void Send(byte[] buffer)
        {
            string data = BitConverter.ToString(buffer);
            Console.WriteLine(string.Format("Serial Port 送出 : {0} ", data));
        }
    }
}