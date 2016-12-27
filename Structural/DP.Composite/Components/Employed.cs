using System;

namespace DP.Composite.Components
{
    abstract class Employed : IEmployed
    {
        public string Name { get; }

        public Employed(string name)
        {
            Name = name;
        }


        public virtual void Display(int indentation)
        {
            Console.WriteLine($"{new string('-', indentation)}+ Name: {Name}");
        }
    }
}
