using System;

namespace SimpleFactorySample002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var commucation = CommucationFactory.GetInstance(CommucationType.SerialPort);
            commucation.Connect("192.168.0.1:8888");
            Console.ReadLine();
        }
    }
}