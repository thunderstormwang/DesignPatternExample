namespace BuilderSample001
{
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
}