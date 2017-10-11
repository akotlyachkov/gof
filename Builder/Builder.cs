namespace Patterns.Builder
{
    public abstract class Builder
    {
        public abstract void SetPartsA();
        public abstract void SetPartsB();
        public abstract Product GetProduct();
    }
}