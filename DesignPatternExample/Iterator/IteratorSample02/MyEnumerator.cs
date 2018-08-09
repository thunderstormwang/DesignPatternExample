using System.Collections;
using System.Collections.Generic;

namespace Iterator.IteratorSample02
{
    public class MyEnumerator : IEnumerator<double>
    {
        private List<double> _list = new List<double>();
        private int _index = -1;

        public MyEnumerator(List<double> list)
        {
            _list = list;
        }

        public double Current
        {
            get
            {
                return _list[_index];
            }
        }

        public bool MoveNext()
        {
            _index++;
            return _index >= _list.Count ? false : true;
        }

        public void Reset()
        {
            // 設定列舉值至它的初始位置, 在集合中第一個元素之前
            _index = -1;
        }

        object IEnumerator.Current
        {
            // 因為 IEnumerator<T> 有繼承 IEnumerator, 你也得實作此方法
            get
            {
                return null;
            }
        }

        public void Dispose()
        {
            // 因為 IEnumerator<T> 有繼承 IDisposable, 你也得實作此方法
        }
    }
}