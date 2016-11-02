using DP.AbstractFactory.Clients;
using DP.AbstractFactory.Factories;
using System;

namespace DP.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var africaContinent = new AnimalWorld<AfricaFactory>();
            africaContinent.RunFoodChain();

            var americaContinent = new AnimalWorld<AmericaFactory>();
            americaContinent.RunFoodChain();

            Console.ReadLine();
        }
    }
}
