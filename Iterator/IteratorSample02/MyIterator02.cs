using System.Collections;
using System.Collections.Generic;

namespace Iterator.IteratorSample02
{
    public class MyIterator02 : IEnumerable<double>
    {
        private List<double> _list = new List<double>() { 0, 1, 2, 3, 4, 5 };

        public IEnumerator<double> GetEnumerator()
        {
            // 傳回能逐一查看集合的物件            
            return new MyEnumerator(_list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // 因為 IEnumerable<T> 有繼承 IEnumerator, 你也得實作此方法
            return null;
        }
    }
}
