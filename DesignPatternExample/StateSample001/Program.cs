using System;

namespace StateSample001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Client 端程式只須認識 StateContext, 不須認識 State 的父類別與實作
            StateContext context = new StateContext();
            for (int i = 0; i < 10; i++)
            {
                context.Request();
            }
            Console.ReadLine();
        }
    }
}