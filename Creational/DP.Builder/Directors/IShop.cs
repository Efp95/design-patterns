using DP.Builder.Builders;

namespace DP.Builder.Directors
{
    interface IShop
    {
        void Construct(VehicleBuilder vehicleBuilder);
        void ShowVehicle();
    }
}
