using DP.Adapter.Adapters;
using DP.Adapter.Targets;
using System;

namespace DP.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var unknown = new Compound();
            unknown.Display();

            var water = new RichCompound(Chemical.Water);
            water.Display();

            var ethanol = new RichCompound(Chemical.Ethanol);
            ethanol.Display();

            var benzene = new RichCompound(Chemical.Benzene);
            benzene.Display();

            Console.ReadLine();
        }
    }
}
