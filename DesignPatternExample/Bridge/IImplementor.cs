using System;

namespace Bridge
{
    public interface IImplementor
    {
        void OperationImp();
    }

    public class ImplementorA : IImplementor
    {
        public void OperationImp()
        {
            Console.WriteLine("Implementor A");
        }
    }

    public class ImplementorB : IImplementor
    {
        public void OperationImp()
        {
            Console.WriteLine("Implementor B");
        }
    }
}