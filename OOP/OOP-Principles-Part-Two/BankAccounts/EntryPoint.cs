namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        static void Main()
        {
            Bank bank = new Bank();

            bank.Accounts.Add(new DepositAccount(Customer.Individual, 2000, 5));
            bank.Accounts.Add(new LoanAccount(Customer.Company, 200000, 15));
            bank.Accounts.Add(new MortgageAccount(Customer.Individual, 1, 200));

            var demonstration = bank.Accounts[1].CalculateInterest(14);

            Console.WriteLine("The Loan Account interest is: " + demonstration);
            Console.WriteLine(bank.Accounts[0]);
        }
    }
}
