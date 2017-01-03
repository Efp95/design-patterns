using DP.Facade.Subsystems;
using System;

namespace DP.Facade.Facades
{
    class Mortgage : IMortgage
    {
        private Customer Customer { get; }

        private Bank Bank { get; }
        private Credit Credit { get; }
        private Loan Loan { get; }


        public Mortgage(Customer customer)
        {
            Customer = customer;

            Bank = new Bank(customer);
            Credit = new Credit(customer);
            Loan = new Loan(customer);
        }


        public bool IsElegible(decimal amount)
        {
            Console.WriteLine($"{Customer.Name} applies for {amount:C} loan\n");

            return Bank.HasSufficientSavings(amount)
                    && Credit.HasGoodCredit()
                    && Loan.HasNoBadLoans();
        }
    }
}
