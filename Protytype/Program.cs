using System;

namespace Protytype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sample01();

            Console.WriteLine("------------------------------");

            Sample02();

            Console.WriteLine("------------------------------");

            Sample03();

            Console.WriteLine("------------------------------");

            Sample04();

            Console.WriteLine("------------------------------");

            Sample05();

            Console.WriteLine("------------------------------");

            Sample06();

            Console.WriteLine("------------------------------");
        }

        private static void Sample01()
        {
            PrototypeSample01.MyRectangle o1 = new PrototypeSample01.MyRectangle();
            o1.Height = 5;
            o1.Width = 8;

            var o2 = (PrototypeSample01.MyRectangle)o1.Clone();
            Console.WriteLine(o2.Width.ToString());
            Console.ReadLine();
        }

        private static void Sample02()
        {
            PrototypeSample02.MyRectangle o1 = new PrototypeSample02.MyRectangle();
            o1.Height = 5;
            o1.Width = 8;

            var o2 = (PrototypeSample02.MyRectangle)o1.Clone();
            Console.WriteLine(o2.Width.ToString());
            Console.ReadLine();
        }

        private static void Sample03()
        {
            PrototypeSample03.MyClass2 o1 = new PrototypeSample03.MyClass2();
            o1.Data.X = 99;
            var o2 = (PrototypeSample03.MyClass2)o1.Clone();
            Console.WriteLine("ReferenceEquals(o1.Data, o2.Data) = " + object.ReferenceEquals(o1.Data, o2.Data));
            Console.ReadLine();
        }

        private static void Sample04()
        {
            PrototypeSample04.MyClass2 o1 = new PrototypeSample04.MyClass2();
            o1.Data.X = 888;
            var o2 = (PrototypeSample04.MyClass2)o1.Clone();
            Console.WriteLine("ReferenceEquals(o1.Data, o2.Data) = " + object.ReferenceEquals(o1.Data, o2.Data));

            Console.ReadLine();
        }

        private static void Sample05()
        {
            var o = PrototypeSample05.ProductsContext.Manager.GetPrototype("ProductA1");

            Console.WriteLine(o.GetType().Name);
            Console.ReadLine();
        }

        private static void Sample06()
        {
            var factory = new PrototypeSample06.Factory1();
            var pa = factory.CreateProductA();
            var pb = factory.CreateProductB();
            Console.WriteLine(pa.GetType().Name);
            Console.WriteLine(pb.GetType().Name);

            Console.ReadLine();
        }
    }
}