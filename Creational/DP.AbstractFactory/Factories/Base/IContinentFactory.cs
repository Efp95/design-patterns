using DP.AbstractFactory.Products.Base;

namespace DP.AbstractFactory.Factories.Base
{
    interface IContinentFactory
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }
}
