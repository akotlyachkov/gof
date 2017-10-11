using System;

namespace Patterns.Abstract
{
    public class Sample
    {
        public static void Exec()
        {
            var clientOne = new Client(new ConcreteFactoryOne());
            clientOne.Test();
            var clientTwo = new Client(new ConcreteFactoryTwo());
            clientTwo.Test();
            Console.ReadKey();
        }
    }
}