using System;

namespace CommandSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            CommandA command = new CommandA(receiver);
            invoker.SetCommnad(command);
            invoker.Action();

            Console.ReadLine();
        }
    }
}