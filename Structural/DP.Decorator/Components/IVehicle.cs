namespace DP.Decorator.Components
{
    interface IVehicle
    {
        string Model { get; }
        decimal Price { get; }

        void Display();
    }
}
