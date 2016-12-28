using DP.Decorator.Components;
using DP.Decorator.Decorators;
using System;

namespace DP.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var kiaPicanto = new KiaPicanto();
            //kiaPicanto.Display();

            var christmasOffer = new ChristmasOffer(kiaPicanto);
            //christmasOffer.Display();

            var specialOffer = new SpecialOffer(christmasOffer);
            specialOffer.Display();


            Console.ReadLine();
        }
    }
}
