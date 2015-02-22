//### Problem 5. Larger than neighbours
//*	Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).


using System;

class LargerThanNeighbours
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
        int index = Array.IndexOf(values, n);
        Console.WriteLine("Number is bigger than its neighbours: " + CheckIfBiggerThanNeighbours(values, n, index));
    }

    static bool CheckIfBiggerThanNeighbours(int[] values, int n, int index)
    {
        bool bigger = false;
        if (index != values.GetLength(0) - 1 && index != 0)
        {
            if (values[index - 1] < values[index] &&
                values[index + 1] < values[index])
            {
                bigger = true;
            }
        }
        return bigger;
    }
}
