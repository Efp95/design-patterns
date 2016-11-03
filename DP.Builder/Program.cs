using DP.Builder.Builders;
using DP.Builder.Directors;
using System;

namespace DP.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            shop.Construct(new ScooterBuilder());
            shop.ShowVehicle();

            shop.Construct(new CarBuilder());
            shop.ShowVehicle();

            shop.Construct(new MotorCycleBuilder());
            shop.ShowVehicle();

            Console.ReadLine();
        }
    }
}
