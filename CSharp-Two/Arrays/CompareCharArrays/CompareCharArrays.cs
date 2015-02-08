//Problem 3. Compare char array

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] arrayOne = new char[] { 'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' };
        char[] arrayTwo = new char[] { 'H', 'e', 'l', 'l', 'o', ' ', 'd', 'u', 'd', 'e', '!' };

        bool equal = true;

        for (int i = 0; i < 11; i++)
        {
            if (arrayOne[i] != arrayTwo[i])
            {
                equal = false;
            }
        }

        Console.WriteLine("The arrays are lexicographically equal: " + equal);
    }
}
