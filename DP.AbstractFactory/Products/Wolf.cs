using DP.AbstractFactory.Products.Base;
using System;

namespace DP.AbstractFactory.Products
{
    class Wolf : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name} in America.");
        }
    }
}
