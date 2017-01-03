using System;

namespace DP.Facade.Subsystems
{
    class Loan
    {
        private Customer _customer;

        public Loan(Customer customer)
        {
            _customer = customer;
        }

        public bool HasNoBadLoans()
        {
            Console.WriteLine($"Check loans for {_customer.Name}");
            // Skip complex logic
            return true;
        }
    }
}
