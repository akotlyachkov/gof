namespace Patterns.Builder
{
    public class ConcreteBuilderOne : Builder
    {
        private readonly Product _product = new Product();

        public override void SetPartsA()
        {
            _product.Add("деталька One A1");
            _product.Add("деталька One A2");
        }

        public override void SetPartsB()
        {
            _product.Add("деталька One B1");
            _product.Add("деталька One B2");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}