namespace BuilderSample001
{
    public class Director
    {
        public Director(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}