//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countTo = (int) Math.Sqrt(n);
        Console.WriteLine(countTo);
        bool prime = false;
        for (int i = 2; i <= countTo + 1; i++)
        {
            prime = (n % i != 0);
            Console.WriteLine(prime);
            if (!prime)
            {
                break;
            }
        }

        if (prime)
        {
            Console.WriteLine("The number is prime!");
        }
        else
        {
            Console.WriteLine("The number is not prime!");
        }
    }
}