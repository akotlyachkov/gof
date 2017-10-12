namespace Patterns.Factory
{
    public class ConcreteFactoryTwo:Factory
    {
        public override Product Create()
        {
            return new ConcreteProductTwo();
        }
    }
}