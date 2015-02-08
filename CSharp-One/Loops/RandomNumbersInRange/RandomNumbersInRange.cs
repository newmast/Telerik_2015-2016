//### Problem 11.	Random Numbers in Given Range
//*	Write a program that enters `3` integers `n`, `min` and `max` (`min != max`) and prints `n` random numbers in the range `[min...max]`.

//_Examples:_

//| n                 | min | max     |         random numbers        |
//|-------------------|-----|---------|-------------------------------|
//| 5                 | 0   | 1       | 1 0 0 1 1                     |
//| 10                | 10  | 15      | 12 14 12 15 10 12 14 13 13 11 |

//_Note: The above output is just an example. Due to randomness, your program most probably will produce different results._

using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("Enter number amount: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter minimum range for randomisation: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter maximum range for randomisation (min != max): ");
        int max = int.Parse(Console.ReadLine());

        Random numberGenerator = new Random();

        Console.Write("Numbers in random range: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(numberGenerator.Next(min, max + 1) + " ");
        }
        Console.WriteLine();
    }
}
