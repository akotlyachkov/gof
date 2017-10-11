using System;

namespace Patterns.Abstract
{
    public class ProductB2 : AbstractProductB
    {
        public override void Price()
        {
            Console.WriteLine("product B2 price: 2000");
        }
    }
}