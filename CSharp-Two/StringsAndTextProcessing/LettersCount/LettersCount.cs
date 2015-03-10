//### Problem 21. Letters count
//*	Write a program that reads a string from the console and prints all different letters in the string along with 
//* information how many times each letter is found. 

using System;
using System.Linq;
class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        string answer = new String(text.Distinct().ToArray());

        int[] countLetters = new int[26];

        text = text.ToUpper();

        for (int i = 0; i < 26; i++)
        {
            countLetters[i] = text.Count(f => f == (char) (i + 65));
        }
        Console.WriteLine("Unique letters: " + answer);
        Console.WriteLine("Times unique letter is found: ");
        for (int i = 0; i < 26; i++)
        {
            if (countLetters[i] != 0)
            {
                Console.WriteLine("{0} - {1}", (char) (i + 65), countLetters[i]);
            }
        }
    }
}