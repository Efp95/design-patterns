using DP.AbstractFactory.Products.Base;
using System;

namespace DP.AbstractFactory.Products
{
    class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name} in Africa.");
        }
    }
}
