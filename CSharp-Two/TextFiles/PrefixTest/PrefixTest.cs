//### Problem 11. Prefix "test"
//*	Write a program that deletes from a text file all words that start with the prefix `test`.
//*	Words contain only the symbols `0…9`, `a…z`, `A…Z`, `_`.

using System;
using System.IO;
using System.Text;
using System.Linq;
class PrefixTest
{
    static void Main(string[] args)
    {;
        StringBuilder result = new StringBuilder();

        using (StreamReader reader = new StreamReader("../../input.txt"))
        {
            string currentLine;
            while (!reader.EndOfStream)
            {
                currentLine = reader.ReadLine();
                string[] separatedWords = currentLine
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => !x.StartsWith("test", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                result.AppendLine(String.Join(" ", separatedWords));
            }
        }

        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            writer.Write(result.ToString());
        }
    }
}