//### Problem 7. Reverse number
//*	Write a method that reverses the digits of given decimal number.

//_Example:_

//| input  | output |
//|:------:|:------:|
//| 256    | 652    |
//| 123.45 | 54.321 |

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string n = Console.ReadLine();
        Console.WriteLine("The number reversed is: " + ReverseNumber(n));
    }
    static string ReverseNumber(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
