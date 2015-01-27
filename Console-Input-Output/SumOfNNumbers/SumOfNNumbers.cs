//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
//Examples:
//numbers	    sum
//3	            90
//20	
//60	
//10
//------------------	
//5	            11.5
//2	
//-1	
//-0.5	
//4	
//2	
//------------------
//1	            1
//1

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how much numbers you're going to be adding up: ");
        uint numberAmount = uint.Parse(Console.ReadLine());

        float result = 0;
        float inputNumber = 0;

        for (int i = 1; i <= numberAmount; i++)
        {
            Console.Write("Enter number " + i + ": ");
            inputNumber = float.Parse(Console.ReadLine());

            result += inputNumber;
        }

        Console.WriteLine("The sum of these " + numberAmount + " numbers is " + result);
    }
}
