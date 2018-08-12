using System.Collections;
using System.Collections.Generic;

namespace IteratorSample001
{
    // 用一個類別去實作兩介面

    public class MyIterator : IEnumerable<double>, IEnumerator<double>
    {
        private List<double> _list = new List<double>() { 0, 1, 2, 3, 4, 5 };
        private int _index = -1;

        public double Current
        {
            get
            {
                return _list[_index];
            }
        }

        public IEnumerator<double> GetEnumerator()
        {
            // 傳回能逐一查看集合的物件
            Reset();
            return this;
        }

        public void Reset()
        {
            // 設定列舉值至它的初始位置, 在集合中第一個元素之前
            _index = -1;
        }

        public bool MoveNext()
        {
            _index++;
            return _index >= _list.Count ? false : true;
        }

        object IEnumerator.Current
        {
            // 因為 IEnumerator<T> 有繼承 IEnumerator, 你也得實作此方法
            get
            {
                return null;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // 因為 IEnumerable<T> 有繼承 IEnumerator, 你也得實作此方法
            return null;
        }

        public void Dispose()
        {
            // 因為 IEnumerator<T> 有繼承 IDisposable, 你也得實作此方法
        }
    }
}