using System;

namespace Command
{
    /// <summary>
    /// 真正執行命令的角色
    /// </summary>
    public class Receiver
    {
        public void DoA()
        {
            Console.WriteLine("A");
        }

        public void DoB()
        {
            Console.WriteLine("B");
        }

        public void DoC()
        {
            Console.WriteLine("C");
        }
    }
}