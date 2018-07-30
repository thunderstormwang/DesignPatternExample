using System;
using System.Text;

namespace AdapterExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICommunication tcp = new TcpCommunication();
            // 假設 127.0.0.1:7
            // 其中 port 7 為 echo service
            tcp.Connect("127.0.0.1:7");
            byte[] sendBuffer = GetSendBuffer();
            tcp.Send(sendBuffer);

            byte[] receiveBuffer = tcp.Receive();
            tcp.Disconnect();
            Console.WriteLine(GetReceiveString(receiveBuffer));

            Console.ReadLine();

            // 如果卡個 Factory 在前面就更美了
        }

        private static byte[] GetSendBuffer()
        {
            string data = "Hello!";
            return Encoding.UTF8.GetBytes(data);
        }

        public static string GetReceiveString(byte[] buffer)
        {
            return Encoding.UTF8.GetString(buffer);
        }
    }
}
