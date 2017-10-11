namespace Patterns.Builder
{
    public class Client
    {
        public Product Construct(Builder builder)
        {
            builder.SetPartsA();
            builder.SetPartsB();
            return builder.GetProduct();
        }
    }
}