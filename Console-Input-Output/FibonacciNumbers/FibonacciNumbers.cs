//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

//Examples:

//n	    comments
//1	    0
//3	    0 1 1
//10	0 1 1 2 3 5 8 13 21 34

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter a number for the sequence: ");
        int n = int.Parse(Console.ReadLine());

        int firstNumber = 0;
        int secondNumber = 1;
        int thirdNumber = 1;
        int currentFibNumber = 0;

        Console.Write(firstNumber + ", " + secondNumber + ", " + thirdNumber);

        for (int i = 3; i < n; i++)
        {
            currentFibNumber = secondNumber + thirdNumber;

            Console.Write(", " + currentFibNumber);

            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = currentFibNumber;
        }
        Console.WriteLine();
    }
}
