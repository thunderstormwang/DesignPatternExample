using System;

namespace SimpleFactryExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var commucation = FactorySample01.CommucationFactory.GetInstance(FactorySample01.CommucationType.Tcp);
            commucation.Connect("192.168.0.1:8888");
            Console.ReadLine();

            var commucation02 = FactorySample02.CommucationFactory.GetInstance(FactorySample02.CommucationType.SerialPort);
            commucation02.Connect("192.168.0.1:8888");
            Console.ReadLine();

            var commucation03 = FactorySample03.CommucationFactory.GetInstance(FactorySample03.CommucationType.Tcp);
            commucation03.Connect("192.168.0.1:8888");
            Console.ReadLine();
        }
    }
}