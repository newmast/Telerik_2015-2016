//### Problem 14. Word dictionary
//*	A dictionary is stored as a sequence of text lines containing words and their explanations.
//*	Write a program that enters a word and translates it by using the dictionary.

//_Sample dictionary:_

//|   input   |                  output                  |
//|:---------:|:----------------------------------------:|
//| .NET      | platform for applications from Microsoft |
//| CLR       | managed execution environment for .NET   |
//| namespace | hierarchical organization of classes     |

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string input = Console.ReadLine();

        var dictionary = new Dictionary<string, string>();

        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        if (dictionary.ContainsKey(input))
        {
            Console.WriteLine(dictionary[input]);
        }
        else
        {
            Console.WriteLine("Definition doesn't exist.");
        }
    }
}