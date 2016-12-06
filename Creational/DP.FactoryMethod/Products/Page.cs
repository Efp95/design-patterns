namespace DP.FactoryMethod.Products
{
    abstract class Page
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
