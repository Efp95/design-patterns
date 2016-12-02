using DP.Prototype.Products;
using System;

namespace DP.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalCustomer = new Customer
            {
                Id = 1,
                Name = "Favourite Customer",
                Address = new Address
                {
                    Id = 2,
                    Avenue = "Very Long Avenue Name"
                }
            };

            var deepClonedCustomer = originalCustomer.DeepClone();
            var shallowClonedCustomer = originalCustomer.ShallowClone();
            
            originalCustomer.Address.Avenue = "None";

            Console.Read();
        }
    }
}
