//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:

//PROGRAM	            USER
//Company name:	        Telerik Academy
//Company address:	    31 Al. Malinov, Sofia
//Phone number:	        +359 888 55 55 555
//Fax number:	        2
//Web site:	            http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	        25
//Manager phone:	    +359 2 981 981

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Web site: ");
        string website = Console.ReadLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Company name: " + companyName);
        Console.WriteLine("Company address: " + companyAddress);
        Console.WriteLine("Phone number: " + phoneNumber);
        Console.WriteLine("Fax number: " + faxNumber);
        Console.WriteLine("Web site: " + website);
        Console.WriteLine("Manager first name: " + managerFirstName);
        Console.WriteLine("Manager last name: " + managerLastName);
        Console.WriteLine("Manager age: " + age);
        Console.WriteLine("Manager phone number: " + managerPhoneNumber);
    }
}
