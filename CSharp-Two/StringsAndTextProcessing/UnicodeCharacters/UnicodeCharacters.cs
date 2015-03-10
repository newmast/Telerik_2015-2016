//### Problem 10. Unicode characters
//*	Write a program that converts a string to a sequence of C# Unicode character literals.
//*	Use format strings.

//_Example:_

//| input |       output       |
//|:-----:|:------------------:|
//| Hi!   | \u0048\u0069\u0021 |

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        foreach (char c in input)
        {
            Console.Write("\\u{0:x4}", (int)c);
        }
        Console.WriteLine();
    }
}