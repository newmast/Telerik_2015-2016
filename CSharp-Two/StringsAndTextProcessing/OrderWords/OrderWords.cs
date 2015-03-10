//### Problem 24. Order words
//*	Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Linq;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter words, separated by space: ");
        string[] text = Console.ReadLine().Split(' ');

        Array.Sort(text);

        foreach (var element in text)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}