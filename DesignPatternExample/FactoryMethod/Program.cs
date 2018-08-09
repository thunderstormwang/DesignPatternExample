using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethodSample01.ICommunication commucation01 = (new FactoryMethodSample01.TcpFactory()).GetInstance();
            commucation01.Connect("192.168.1.1:5555");

            Console.ReadLine();

            //------

            FactoryMethodSample02.ICommunication commucation02 = (new FactoryMethodSample02.SerialPortFactory()).GetInstance();
            commucation02.Connect("COM2");

            Console.ReadLine();
        }
    }
}