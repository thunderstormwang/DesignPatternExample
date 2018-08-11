namespace Builder
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