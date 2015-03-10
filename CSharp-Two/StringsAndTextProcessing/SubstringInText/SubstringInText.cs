//### Problem 4. Sub-string in text
//*	Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//_Example:_
//The target sub-string is `in`
//The text is as follows:
//We are liv**in**g **in** an yellow submar**in**e. We don't have anyth**in**g else. **in**side the submar**in**e is very tight. So we are dr**in**k**in**g all the day. We will move out of it **in** 5 days.
//The result is: `9`

using System;
using System.Text.RegularExpressions;

class SubstringInText
{
    static void Main()
    {
        Console.Write("Enter substring to look for: ");
        string substring = Console.ReadLine();
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        int occurs = Regex
                     .Matches(text, substring, RegexOptions.IgnoreCase)
                     .Count;
        Console.WriteLine("Number of times: " + occurs);
    }
}