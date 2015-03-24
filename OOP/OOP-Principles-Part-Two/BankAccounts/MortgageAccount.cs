namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, int interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer == Customer.Company )
            {
                if (numberOfMonths <= 12)
                {
                    return numberOfMonths * ( this.InterestRate / 2);
                }
                else
                {
                    return (numberOfMonths - 12) * this.InterestRate + 12 * (this.InterestRate / 2);
                }
            }
            else
            {
                if (numberOfMonths <= 6)
                {
                    return 0;
                }
                else
                {
                    return (numberOfMonths - 6) * this.InterestRate;
                }
            }
        }

    }
}
