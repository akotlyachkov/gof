namespace Patterns.Factory
{
    public class ConcreteFactoryOne:Factory
    {
        public override Product Create()
        {
            return new ConcreteProductOne();
        }
    }
}