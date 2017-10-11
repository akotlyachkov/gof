using System;

namespace Patterns.Builder
{
    public class Sample
    {
        public static void Exec()
        {
            var client = new Client();

            var productOne = client.Construct(new ConcreteBuilderOne());
            var productTwo = client.Construct(new ConcreteBuilderTwo());

            Console.WriteLine("\nproductOne");
            productOne.Show();

            Console.WriteLine("\nproductTwo");

            productTwo.Show();

            Console.Read();
        }
    }
}