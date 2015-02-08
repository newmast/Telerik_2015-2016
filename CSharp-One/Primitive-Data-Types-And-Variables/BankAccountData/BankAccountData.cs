//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ronald";
        string middleName = "MC";
        string lastName = "Donald";
        string holderName = firstName + " " + middleName + " " + lastName;

        decimal balance = 666666666666666666666M;

        string bankName = "Hamburger CO.";
        string IBAN = "HAM665BURGERS41911";

        long creditCard1 = 48700249356731265L;
        long creditCard2 = 95674524938590657L;
        long creditCard3 = 84254215775418674L;
    }
}
