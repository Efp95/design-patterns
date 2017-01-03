using DP.Facade.Facades;
using System;

namespace DP.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer { Name = "Uncle Bob" };
            IMortgage mortgage = new Mortgage(customer);

            bool isEligible = mortgage.IsElegible(125000);
            string status = isEligible ? "Approved" : "Rejected";

            Console.WriteLine($"\n{customer.Name} has been {status}");

            Console.ReadLine();
        }
    }
}
