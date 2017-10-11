using System;
using System.Collections.Generic;

namespace Patterns.Builder
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            _parts.ForEach(Console.WriteLine);
        }
    }
}