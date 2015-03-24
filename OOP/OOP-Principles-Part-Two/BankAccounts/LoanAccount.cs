namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, int interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer == Customer.Individual)
            {
                return (numberOfMonths - 3) * this.InterestRate;
            }
            else if (this.Customer == Customer.Company)
            {
                return (numberOfMonths - 2) * this.InterestRate;
            }
            return base.CalculateInterest(numberOfMonths);
        }
    }
}
