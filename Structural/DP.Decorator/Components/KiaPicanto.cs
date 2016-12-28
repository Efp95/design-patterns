using System;

namespace DP.Decorator.Components
{
    class KiaPicanto : IVehicle
    {
        public string Model
        {
            get
            {
                return "Kia Picanto";
            }
        }

        public decimal Price
        {
            get
            {
                return 25000;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Kia Picanto's base price is: {Price}");
        }
    }
}
