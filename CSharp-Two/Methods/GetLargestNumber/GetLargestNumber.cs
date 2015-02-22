//### Problem 2. Get largest number
//*	Write a method `GetMax()` with two parameters that returns the larger of two integers.
//*	Write a program that reads `3` integers from the console and prints the largest of them using the method `GetMax()`.


using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        int number3 = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(number, GetMax(number2, number3)));
    }
    static int GetMax(int a, int b)
    {
        int max = a;
        if (b >= a)
        {
            max = b;
        }
        return max;
    }
}
