//### Problem 8.	Catalan Numbers
//*	In combinatorics, the Catalan numbers are calculated by the following formula:
// http://puu.sh/fl6rn/0a5bc71316.jpg
//*	Write a program to calculate the n-th Catalan number by given `n`. 

//_Examples:_

//| n           | Catalan(n) |
//|-------------|------------|
//| 0           | 1          |
//| 5           | 42         |
//| 10          | 16796      |
//| 15          | 9694845    |

using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Which Catalan number do you want to calculate? ");
        int n = int.Parse(Console.ReadLine());

        double factTwoN = 1;
        double factOnePlusN = 1;
        double factN = 1;
        long answer = 0;

        for (int i = 1; i <= 2*n; i++)
        {
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }
            factTwoN *= i; // (2n)!

            if (i <= n+1) // (n + 1)!
            {
                factOnePlusN *= i;
            }

            if (i <= n) // n!
            {
                factN *= i;
            }
        }

        answer = (long)(factTwoN / (factOnePlusN * factN));
        Console.WriteLine("Catalan({0}) == {1}", n, answer);
    }
}
