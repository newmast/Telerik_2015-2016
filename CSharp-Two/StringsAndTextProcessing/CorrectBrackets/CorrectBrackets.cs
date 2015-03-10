//### Problem 3. Correct brackets
//*	Write a program to check if in a given expression the brackets are put correctly.

//_Example of correct expression:_ `((a+b)/5-d)`.
//_Example of incorrect expression:_ `)(a+b))`.

using System;
using System.Linq;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter a math expression with brackets: ");
        string input = Console.ReadLine();

        int bracketCounter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                bracketCounter++;
            }
            else if (input[i] == ')')
            {
                bracketCounter--;
            }
        }

        if (bracketCounter == 0)
        {
            Console.WriteLine("Valid expression.");
        }
        else
        {
            Console.WriteLine("Invalid expression.");
        }
    }
}