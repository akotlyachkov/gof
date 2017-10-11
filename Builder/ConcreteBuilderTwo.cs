namespace Patterns.Builder
{
    public class ConcreteBuilderTwo : Builder
    {
        private readonly Product _product = new Product();

        public override void SetPartsA()
        {
            _product.Add("деталька Two A1");
            _product.Add("деталька Two A2");
        }

        public override void SetPartsB()
        {
            _product.Add("деталька Two B1");
            _product.Add("деталька Two B2");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}