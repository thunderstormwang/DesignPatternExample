using System;

namespace VistorSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PropertyVisitor visitor = new PropertyVisitor();
            ObjectStructure o = new ObjectStructure();
            foreach (var item in o.Elements)
            {
                item.Accept(visitor);
            }

            Console.ReadLine();
        }
    }
}