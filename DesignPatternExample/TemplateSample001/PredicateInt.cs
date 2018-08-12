using System.Collections.Generic;

namespace TemplateSmple001
{
    public class PredicateInt : CustomClass<int>
    {
        public PredicateInt(IEnumerable<int> source) : base(source)
        { }

        protected override bool Predicate(int item)
        {
            return item > 3;
        }
    }
}