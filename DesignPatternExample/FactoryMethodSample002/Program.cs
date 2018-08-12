using System;

namespace FactoryMethodSample002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICommunication commucation = (new SerialPortFactory()).GetInstance();
            commucation.Connect("COM2");

            Console.ReadLine();
        }
    }
}