//### Problem 4.  Appearance count
//*	Write a method that counts how many times given number appears in given array.
//*	Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
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

        Console.WriteLine("Times number is in the array: " + TimesNumberInArray(values, n));
    }
    static int TimesNumberInArray(int[] values, int number)
    {
        int count = 0;

        for (int i = 0; i < values.GetLength(0); i++)
        {
            if (values[i] == number)
            {
                count++;
            }
        }
        return count;
    }
}
