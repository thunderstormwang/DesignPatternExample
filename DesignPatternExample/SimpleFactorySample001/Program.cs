using System;

namespace SimpleFactorySample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var commucation = CommucationFactory.GetInstance(CommucationType.Tcp);
            commucation.Connect("192.168.0.1:8888");
            Console.ReadLine();
        }
    }
}