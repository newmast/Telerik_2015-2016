//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Examples:

//n	        Third digit 7?
//5	        false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true

using System;

class IsThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isThirdDigit7 = ((number / 100) % 10 == 7);

        Console.WriteLine(isThirdDigit7);
    }
}

