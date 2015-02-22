//### Problem 6. First larger than neighbours
//*	Write a method that returns the index of the first element in array that is larger than its neighbours, or `-1`, if there�s no such element.
//*	Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter array length: ");
        int arrLength = int.Parse(Console.ReadLine());

        int[] values = new int[arrLength];

        for (int i = 0; i < values.GetLength(0); i++)
        {
            Console.Write("[{0}]: ", i);
            values[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Number is bigger than its neighbours: " + CheckIfBiggerThanNeighbours(values, n));
    }

    static int CheckIfBiggerThanNeighbours(int[] values, int n)
    {
        int firstFoundNumber = -1;

        for (int i = 1; i < values.GetLength(0) - 1; i++)
        {
            if (values[i - 1] < values[i] &&
                values[i + 1] < values[i])
            {
                firstFoundNumber = values[i];
            }
        }

        return firstFoundNumber;
    }
}
