using DP.Builder.Products;

namespace DP.Builder.Builders
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
            : base(VehicleType.Car)
        {
        }

        public override void BuildFrame()
        {
            Vehicle[PartType.Frame] = "Car Frame";
        }

        public override void BuildEngine()
        {
            Vehicle[PartType.Engine] = "2500 cc";
        }

        public override void BuildWheels()
        {
            Vehicle[PartType.Wheel] = "4";
        }

        public override void BuildDoors()
        {
            Vehicle[PartType.Door] = "4";
        }
    }
}
