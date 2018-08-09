using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.TemplateSample
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
