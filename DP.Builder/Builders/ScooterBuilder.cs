using DP.Builder.Products;

namespace DP.Builder.Builders
{
    class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder() : base(VehicleType.Scooter)
        {
        }

        public override void BuildFrame()
        {
            Vehicle[PartType.Frame] = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            Vehicle[PartType.Engine] = "50 cc";
        }

        public override void BuildWheels()
        {
            Vehicle[PartType.Wheel] = "2";
        }

        public override void BuildDoors()
        {
            Vehicle[PartType.Door] = "0";
        }
    }
}
