namespace Patterns.Abstract
{
    public class Client
    {
        private AbstractProductA _productA;
        
        private AbstractProductB _productB;
        
        public Client( Factory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Test()
        {
            _productA.Model();
            _productB.Price();
        }
    }
}