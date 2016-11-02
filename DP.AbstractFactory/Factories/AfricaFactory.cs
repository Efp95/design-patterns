using DP.AbstractFactory.Factories.Base;
using DP.AbstractFactory.Products;
using DP.AbstractFactory.Products.Base;

namespace DP.AbstractFactory.Factories
{
    class AfricaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
