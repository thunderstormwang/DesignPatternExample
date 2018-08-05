using System;
using System.Collections.Generic;

namespace Protytype.PrototypeSample05
{
    public class PrototypeManager
    {
        private Dictionary<string, ICloneable> _objects;

        public PrototypeManager()
        {
            _objects = new Dictionary<string, ICloneable>();
        }

        public void AddPrototype(string name, ICloneable value)
        {
            if (_objects.ContainsKey(name) == false)
            {
                _objects.Add(name, value);
            }
        }

        public ICloneable GetPrototype(string name)
        {
            if (_objects.ContainsKey(name))
            {
                return (ICloneable)_objects[name].Clone();
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    /// <summary>
    /// 使用 ProrotypeManager 的上下文介面
    /// </summary>
    public class ProductsContext
    {
        private static PrototypeManager _manager;
        public static PrototypeManager Manager
        {
            get
            {
                if (_manager == null)
                {
                    CreateManager();
                }
                return _manager;
            }
        }

        private static void CreateManager()
        {
            _manager = new PrototypeManager();
            _manager.AddPrototype("ProductA1", new ProductA1());
            _manager.AddPrototype("ProductA2", new ProductA2());
            _manager.AddPrototype("ProductB1", new ProductB1());
            _manager.AddPrototype("ProductB2", new ProductB2());
        }
    }
}
