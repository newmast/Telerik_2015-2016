//### Problem 5. Parse tags
//*	You are given a text. Write a program that changes the text in all regions surrounded by the tags `<upcase>` and `</upcase>` to upper-case.
//*	The tags cannot be nested.

//_Example:_ We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//_The expected result:_ We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Linq;

class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Input text: ");
        string text = Console.ReadLine();

        string[] processed = text.Split(new string[] { "<upcase>", "</upcase>" }, StringSplitOptions.None);

        string newResult = "";

        for (int i = 0; i < processed.Length; i++)
        {
            if (i % 2 == 0)
            {
                newResult += processed[i];
            }
            else
            {
                newResult += processed[i].ToUpper();
            }
        }
        Console.WriteLine(newResult);
    }
}