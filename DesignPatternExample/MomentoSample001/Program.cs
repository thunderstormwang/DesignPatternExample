using System;

namespace MomentoSample001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "Dog";

            // 儲存狀態
            Caretaker caretacker = new Caretaker();
            caretacker.Memento = originator.CreateMemento();

            // 改變狀態
            originator.State = "Cat";
            originator.ShowState();

            // 回覆狀態
            originator.SetMemento(caretacker.Memento);
            originator.ShowState();

            Console.ReadLine();
        }
    }
}