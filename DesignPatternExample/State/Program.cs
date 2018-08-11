using System;

namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StateExample01();

            StateExample02();

            StateExample03();
        }

        private static void StateExample01()
        {
            // Client 端程式只須認識 StateContext, 不須認識 State 的父類別與實作
            StateExample01.StateContext context = new StateExample01.StateContext();
            for (int i = 0; i < 10; i++)
            {
                context.Request();
            }
            Console.ReadLine();
        }

        private static void StateExample02()
        {
            StateExample02.StateContext context = new StateExample02.StateContext();
            for (int i = 0; i < 10; i++)
            {
                context.Request();
            }
            Console.ReadLine();
        }

        private static void StateExample03()
        {
            throw new NotImplementedException();
        }
    }
}