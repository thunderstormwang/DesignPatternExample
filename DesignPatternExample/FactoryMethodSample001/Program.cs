using System;

namespace FactoryMethodSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICommunication commucation = (new TcpFactory()).GetInstance();
            commucation.Connect("192.168.1.1:5555");

            Console.ReadLine();
        }
    }
}