namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Account
    {
        public Account(Customer customer, decimal balance, int interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public int InterestRate { get; set; }

        public virtual decimal CalculateInterest(int numberOfMonths)
        {
            return numberOfMonths * this.InterestRate;
        }

        public void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override string ToString()
        {
            return string.Format("{0} | Balance = {1} | Interest rate = {2}", Customer, Balance, InterestRate);
        }
    }
}
