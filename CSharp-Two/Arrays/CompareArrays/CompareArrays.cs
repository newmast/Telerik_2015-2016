//### Problem 2. Compare arrays
//*	Write a program that reads two `integer` arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter elements of array one (separated by space): ");
        string arrayOne = Console.ReadLine();

        string[] stringOne = arrayOne.Split(' ');

        Console.Write("Enter elements of array two (separated by space): ");
        string arrayTwo = Console.ReadLine();

        string[] stringTwo = arrayTwo.Split(' ');

        int[] numbersOne = new int[stringOne.Length];
        int[] numbersTwo = new int[stringTwo.Length];

        for (int i = 0; i < stringOne.Length; i++)
        {
            numbersOne[i] = int.Parse(stringOne[i]);
        }

        for (int i = 0; i < stringTwo.Length; i++)
        {
            numbersTwo[i] = int.Parse(stringTwo[i]);
        }

        if (numbersOne.Length != numbersTwo.Length)
        {
            Console.WriteLine("The arrays are different.");
        }
        else
        {
            int min = Math.Min(numbersOne.Length, numbersTwo.Length);
            bool different = false;
            for (int i = 0; i < min; i++)
            {
                if (numbersOne[i] != numbersTwo[i])
	            {
                    different = true;
	            }
            }
            if (!different)
            {
                Console.WriteLine("The arrays are the same.");
            }
            else
            {
                Console.WriteLine("The arrays are different.");
            }
        }

    }
}
