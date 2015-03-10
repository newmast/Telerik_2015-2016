//### Problem 22. Words count
//*	Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Enter some words: ");
        string[] text = Console.ReadLine().Split(' ');

        var uniqueWords = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            bool contained = false;
            for (int j = 0; j < uniqueWords.Count; j++)
            {
                if (uniqueWords[j] == text[i])
                {
                    contained = true;
                    break;
                }
            }
            if (!contained)
            {
                uniqueWords.Add(text[i]);
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Unique words: ");
        Console.ForegroundColor = ConsoleColor.White;

        foreach (var word in uniqueWords)
        {
            Console.WriteLine(word);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Times each word is found: ");
        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 0; i < uniqueWords.Count; i++)
        {
            int count = 0;
            for (int j = 0; j < text.Length; j++)
            {
                if (uniqueWords[i] == text[j])
                {
                    count++;
                    text[j] = "";
                }
            }
            if (count != 1)
            {
                Console.WriteLine(uniqueWords[i] + " is found " + count + " times.");
            }
            else
            {
                Console.WriteLine(uniqueWords[i] + " is found " + count + " time.");
            }
        }
    }
}