//### Problem 23. Series of letters
//*	Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

//_Example:_

//|          input          |  output  |
//|:-----------------------:|:--------:|
//| aaaaabbbbbcdddeeeedssaa | abcdedsa |

using System;
using System.Collections.Generic;

class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        var result = new List<char>();

        result.Add(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                result.Add(input[i]);
            }
        }
        foreach (var letter in result)
        {
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}