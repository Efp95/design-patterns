using DP.AbstractFactory.Factories.Base;
using DP.AbstractFactory.Products;
using DP.AbstractFactory.Products.Base;

namespace DP.AbstractFactory.Factories
{
    class AmericaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
