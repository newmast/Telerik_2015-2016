//### Problem 20. Palindromes
//*	Write a program that extracts from a given text all palindromes, e.g. `ABBA`, `lamal`, `exe`.

using System;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string[] text = Console.ReadLine().Split(' ');

        for (int i = 0; i < text.Length; i++)
        {
            string reversed = "";

            for (int j = text[i].Length - 1; j >= 0; j--)
			{
			    reversed += text[i][j];
			}
            if (text[i] == reversed)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}