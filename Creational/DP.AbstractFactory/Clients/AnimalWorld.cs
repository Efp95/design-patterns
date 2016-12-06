using DP.AbstractFactory.Factories.Base;
using DP.AbstractFactory.Products.Base;

namespace DP.AbstractFactory.Clients
{
    class AnimalWorld<T> : IAnimalWorld
        where T : IContinentFactory, new()
    {
        T _factory;
        IHerbivore _herbivore;
        ICarnivore _carnivore;

        public AnimalWorld()
        {
            _factory = new T();

            _herbivore = _factory.CreateHerbivore();
            _carnivore = _factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
