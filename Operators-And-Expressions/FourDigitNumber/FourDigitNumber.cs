//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

//Examples:

//n	        sum of digits	reversed	last digit in front	  second and third digits exchanged
//2011	    4	            1102	    1201	              2101
//3333	    12	            3333	    3333	              3333
//9876	    30	            6789	    6987	              9786

using System;

class FourDigitNumber
{

    static void Main()
    {
        Console.WriteLine("Input a number:");
        int number = int.Parse(Console.ReadLine());

        int numberCopy = number;
        int result = 0;
        string numberToText;

        while (numberCopy > 0)
        {
            result += numberCopy % 10;
            numberCopy /= 10;
        }

        Console.WriteLine("Sum of digits: " + result);

        numberCopy = number;
        result = 0;

        while (numberCopy > 0)
        {
            result *= 10;
            result += numberCopy % 10;
            numberCopy /= 10;
        }

        Console.WriteLine("Numbers reversed: " + result);

        numberCopy = number;
        result = 0;

        result = numberCopy % 10;
        numberCopy /= 10;

        numberToText = result.ToString();
        numberToText += numberCopy;

        Console.WriteLine("Last digit in front: " + numberToText);

        numberToText = "" + number;
        char[] numberToCharArray = numberToText.ToCharArray();

        char temp = numberToCharArray[1];
        numberToCharArray[1] = numberToCharArray[2];
        numberToCharArray[2] = temp;

        numberToText = new string(numberToCharArray);

        Console.WriteLine("Second and third digits swapped: " + numberToText);

    }

}