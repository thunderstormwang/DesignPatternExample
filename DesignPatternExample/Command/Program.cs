using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
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
