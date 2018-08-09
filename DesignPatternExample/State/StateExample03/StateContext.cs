using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.StateExample03
{
    /// <summary>
    /// 結合 Registry of Singleton, 避免一直在 new 新的狀態類別，可能有一直在重整 heap 空間的效能問題
    /// </summary>
    public class StateContext
    {
        private Dictionary<string, AbstractState> registry = new Dictionary<string, AbstractState>();

        internal AbstractState GetInstance<T>() where T : AbstractState, new()
        {
            Type type = typeof(T);
            string key = type.Name;
            if (!registry.ContainsKey(key))
            {
                registry[key] = new T();
            }

            return (T)registry[key];
        }

        public StateContext()
        {
            Current = GetInstance<State1>();
        }

        internal AbstractState Current { get; set; }

        public void Request()
        {
            if (Current != null)
            {
                Current.Handle(this);
            }
        }
    }
}
