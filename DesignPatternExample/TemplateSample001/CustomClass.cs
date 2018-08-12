using System.Collections.Generic;

namespace TemplateSmple001
{
    public abstract class CustomClass<T>
    {
        private IEnumerable<T> _source;

        public CustomClass(IEnumerable<T> source)
        {
            _source = source;
        }

        public IEnumerable<T> DoWhere()
        {
            // 父類只定義 DoWhere 是迴圈, 但迴圈內容(Predicate)是什麼, 由繼承的子類別決定

            foreach (var item in _source)
            {
                if (Predicate(item))
                {
                    yield return item;
                }
            }
        }

        protected abstract bool Predicate(T item);
    }
}