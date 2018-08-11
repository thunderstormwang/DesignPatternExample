using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 可層層堆疊
            Component c = new ConcreteComponent();
            Component da = new ConcreteDecoratorA(c);
            Component db = new ConcreteDecoratorB(da);
            db.Operation();

            Console.ReadLine();

        }
    }
}
