using System;

namespace DP.Facade.Subsystems
{
    class Credit
    {
        private Customer _customer;

        public Credit(Customer customer)
        {
            _customer = customer;
        }

        public bool HasGoodCredit()
        {
            Console.WriteLine($"Check credit status for {_customer.Name}");
            // Skip complex logic
            return true;
        }
    }
}
