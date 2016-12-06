using System;
using System.Collections.Generic;

namespace DP.Builder.Products
{
    public class Vehicle
    {
        VehicleType _vehicleType;
        Dictionary<PartType, string> _verhicleParts = new Dictionary<PartType, string>();

        public Vehicle(VehicleType vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public string this[PartType key]
        {
            get { return _verhicleParts[key]; }
            set { _verhicleParts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Vehicle Type: {_vehicleType}");
            Console.WriteLine($" Frame  : {this[PartType.Frame]}");
            Console.WriteLine($" Engine : {this[PartType.Engine]}");
            Console.WriteLine($" #Wheels: {this[PartType.Wheel]}");
            Console.WriteLine($" #Doors : {this[PartType.Door]}");
        }
    }
}
