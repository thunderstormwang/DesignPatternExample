using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorSample003
{
    public class MyIterator : IEnumerable<double>
    {
        private List<double> _list = new List<double>() { 0, 1, 2, 3, 4, 5 };

        public IEnumerator<double> GetEnumerator()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                yield return _list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // 因為 IEnumerable<T> 有繼承 IEnumerator, 你也得實作此方法
            throw new NotImplementedException();
        }
    }
}