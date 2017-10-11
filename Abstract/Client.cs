namespace Patterns.Abstract
{
    public class Client
    {
        private AbstractProductA productA;
        
        private AbstractProductB productB;
        
        public Client( AbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void Test()
        {
            productA.Model();
            productB.Price();
        }
    }
}