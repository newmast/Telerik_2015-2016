//### Problem 12. Index of letters
//*	Write a program that creates an array containing all letters from the alphabet (`A-Z`).
//*	Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(65 + i);
        }

        Console.Write("Enter a word (capital letters only): ");
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 65 && input[i] <= 90)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (input[i] == alphabet[j])
                    {
                        Console.Write(input[i] + " is at index [{0}].", j);
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

