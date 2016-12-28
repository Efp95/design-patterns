using DP.Decorator.Components;

namespace DP.Decorator.Decorators
{
    abstract class VehicleDecorator : IVehicle
    {
        protected IVehicle _vehicle;

        public VehicleDecorator(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }


        public virtual string Model
        {
            get
            {
                return _vehicle.Model;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return _vehicle.Price;
            }
        }


        public abstract void Display();
    }
}
