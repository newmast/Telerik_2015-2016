namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, int interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Balance > 0 &&
                this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return numberOfMonths * this.InterestRate;
            }
        }

        public void Withdraw(decimal sum)
        {
            this.Balance -= sum;
        }
    }
}
