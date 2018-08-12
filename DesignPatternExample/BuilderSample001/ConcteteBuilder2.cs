namespace BuilderSample001
{
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