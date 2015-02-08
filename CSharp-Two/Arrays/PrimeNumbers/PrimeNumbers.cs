//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        int length = 10000001; // modify to change range
        bool[] notPrimes = new bool[length];
        bool checking = false;

        for (int i = 2; i < length; i++)
        {
            checking = false;
            for (int j = i*i; j < length; j+=i)
            {
                if (notPrimes[j] == false)
                {
                    notPrimes[j] = true;
                    checking = true;
                }
            }
            if (!checking)
            {
                break;
            }
        }
        int counter = 1;
        for (int i = 2; i < length; i++)
        {
            if (notPrimes[i] == false)
            {
                Console.Write(i + " | ");
            }
            
            if (counter % 1500 == 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press enter to view more.");
                Console.ReadLine();
                Console.WriteLine();
            }
            counter++;
        }
        Console.WriteLine();
    }
}
