//### Problem 8. Digit as Word
//*	Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//*	Print `“not a digit”` in case of invalid input.
//*	Use a switch statement.

//_Examples:_

//| d    | result      |
//|------|-------------|
//| 2    | two         |
//| 1    | one         |
//| 0    | zero        |
//| 5    | five        |
//| -0.1 | not a digit |
//| hi   | not a digit |
//| 9    | nine        |
//| 10   | not a digit |

using System;

class DigitAsWord
{
    static void Main()
    {
        string digit = Console.ReadLine();

        if ((digit[0] < '0' || digit[0] > '9') || (digit.Length != 1))
        {
            Console.WriteLine("Not a digit.");
            return;
        }

        string digitAsWord = "";

        switch(digit[0])
        {
            case '0':
                digitAsWord = "zero";
                break;
            case '1':
                digitAsWord = "one";
                break;
            case '2':
                digitAsWord = "two";
                break;
            case '3':
                digitAsWord = "three";
                break;
            case '4':
                digitAsWord = "four";
                break;
            case '5':
                digitAsWord = "five";
                break;
            case '6':
                digitAsWord = "six";
                break;
            case '7':
                digitAsWord = "seven";
                break;
            case '8':
                digitAsWord = "eight";
                break;
            case '9':
                digitAsWord = "nine";
                break;

        }
        Console.WriteLine("The digit as a word: " + digitAsWord + ".");
    }
}
