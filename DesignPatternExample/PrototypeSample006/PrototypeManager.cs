using System;
using System.Collections.Generic;

namespace ProtytypeSample006
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
}