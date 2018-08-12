using System;

namespace MomentoSample001
{
    public class Originator
    {
        public string State { get; set; }

        /// <summary>
        /// 建立備忘錄
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        /// <summary>
        /// 還原備忘錄
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }

        public void ShowState()
        {
            Console.WriteLine(State);
        }
    }
}