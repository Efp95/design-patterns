using DP.Composite.Composites;
using DP.Composite.Leafs;
using System;

namespace DP.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Composite Company ==\n");

            var boss = new Employee("Boss");

            var first = new Employee("First Subordinate");
            var second = new Employee("Second Subordinate");
            var third = new Employee("Third Subordinate");
            var fourth = new Employee("Fourth Subordinate");

            boss.AddSubordinate(first);
            boss.AddSubordinate(second);
            boss.AddSubordinate(third);

            first.AddSubordinate(new Employee("First_First Subordinate"));
            first.AddSubordinate(new Employee("First_Second Subordinate"));

            second.AddSubordinate(new Employee("Second_First Subordinate"));
            second.AddSubordinate(new Contractor("Second_Second Subordinate"));
            second.AddSubordinate(new Contractor("Second_Third Subordinate"));

            boss.RemoveSubordinate(fourth);

            boss.Display(1);

            Console.ReadLine();
        }
    }
}
