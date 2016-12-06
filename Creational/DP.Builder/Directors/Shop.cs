using DP.Builder.Builders;

namespace DP.Builder.Directors
{
    class Shop : IShop
    {
        VehicleBuilder _vehicleBuilder;

        public void Construct(VehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;

            _vehicleBuilder.BuildFrame();
            _vehicleBuilder.BuildEngine();
            _vehicleBuilder.BuildWheels();
            _vehicleBuilder.BuildDoors();
        }

        public void ShowVehicle()
        {
            _vehicleBuilder.Vehicle.Show();
        }
    }
}
