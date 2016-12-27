namespace DP.Composite.Components
{
    interface IEmployed
    {
        string Name { get; }

        void AddSubordinate(IEmployed subordinate);
        void RemoveSubordinate(IEmployed subordinate);

        void Display(int indentation);
    }
}
