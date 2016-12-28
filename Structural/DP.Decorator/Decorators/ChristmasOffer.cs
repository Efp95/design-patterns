using DP.Decorator.Components;
using System;

namespace DP.Decorator.Decorators
{
    class ChristmasOffer : VehicleDecorator
    {
        public ChristmasOffer(IVehicle vehicle)
            : base(vehicle)
        {
        }

        public string Offer => "Christmas Offer";
        public int DiscountPercentage => 35;

        public override decimal Price
        {
            get
            {
                int percentageToPay = 100 - DiscountPercentage;

                return Math.Round((base.Price * percentageToPay) / 100, 2);
            }
        }

        public override void Display()
        {
            _vehicle.Display();
            Console.WriteLine($"-{DiscountPercentage}% discount @ {Offer} and price is: {Price}");
        }
    }
}
