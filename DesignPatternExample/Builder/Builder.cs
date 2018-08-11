using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
    }

    public class ConcteteBuilder1 : Builder
    {
        private Product _result;

        public ConcteteBuilder1()
        {
            _result = new Product();
        }

        public Product GetResult()
        {
            return _result;
        }

        public override void BuildPartA()
        {
            _result.PropertyA = "Product A";
        }

        public override void BuildPartB()
        {
            _result.PropertyB = "Parts A-B";
        }

        public override void BuildPartC()
        {
            _result.PropertyC = 100;
        }
    }

    public class ConcteteBuilder2 : Builder
    {
        private Product _result;

        public ConcteteBuilder2()
        {
            _result = new Product();
        }

        public Product GetResult()
        {
            return _result;
        }

        public override void BuildPartA()
        {
            _result.PropertyA = "Product B";
        }

        public override void BuildPartB()
        {
            _result.PropertyB = "Parts B-B";
        }

        public override void BuildPartC()
        {
            _result.PropertyC = 100;
        }
    }
}
