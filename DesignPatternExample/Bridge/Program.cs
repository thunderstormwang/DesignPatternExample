using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RefindAbstraction o = new RefindAbstraction(new ImplementorA());
            o.Operation();

            Console.ReadLine();

        }
    }
}
