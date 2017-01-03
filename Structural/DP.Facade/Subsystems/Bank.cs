using System;

namespace DP.Facade.Subsystems
{
    class Bank
    {
        private Customer _customer;

        public Bank(Customer customer)
        {
            _customer = customer;
        }

        public bool HasSufficientSavings(decimal amount)
        {
            Console.WriteLine($"Check bank status for {_customer.Name}");
            // Skip complex logic
            return true;
        }
    }
}
