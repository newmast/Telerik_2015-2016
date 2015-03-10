//### Problem 13. Reverse sentence
//*	Write a program that reverses the words in given sentence.

//_Example:_

//|                   input                  |                  output                  |
//|:----------------------------------------:|:----------------------------------------:|
//| `C# is not C++, not PHP and not Delphi!` | `Delphi not and PHP, not C++ not is C#!` |

using System;
using System.Text;
class ReverseSentence
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ', ',', '.', '!' },
          StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        char sign = input[input.Length - 1];

        int spaces = 0;
        int commasCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ',')
            {
                commasCount++;
            }
        }

        int[] commaPositions = new int[commasCount];
        int currentComma = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                spaces++;
            }

            if (input[i] == ',')
            {
                commaPositions[currentComma] = spaces;
                currentComma++;
            }
        }

        StringBuilder result = new StringBuilder();

        char lastSign = input[input.Length - 1];
        currentComma = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (i == words.Length - 1)
            {
                result.Append(words[i] + lastSign);
            }
            else if (i == commaPositions[currentComma])
            {
                result.Append(words[i] + ", ");
                if (currentComma < commaPositions.Length - 1)
                {
                    currentComma++;
                }
            }
            else
            {
                result.Append(words[i] + " ");
            }
        }

        Console.WriteLine(result.ToString());
    }
}