using System;

namespace VistorSample001
{
    public class PropertyVisitor : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine(element.X);
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine(element.Y);
        }
    }
}