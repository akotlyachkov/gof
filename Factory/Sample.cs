using System;

namespace Patterns.Factory
{
    public class Sample
    {
        public static void Exec()
        {
            Factory factory1 = new ConcreteFactoryOne();
            Product product1 = factory1.Create();
            Console.WriteLine(product1.GetProdType());

            Factory factory2 = new ConcreteFactoryTwo();
            Product product2 = factory2.Create();
            Console.WriteLine(product2.GetProdType());
        }
    }
}