//### Problem 9. Forbidden words
//*	We are given a string containing a list of forbidden words and a text containing some of these words.
//*	Write a program that replaces the forbidden words with asterisks.

//_Example text: Microsoft announced its next generation PHP compiler today.
//_It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//_Forbidden words:_ `PHP`, `CLR`, `Microsoft`

//_The expected result:_ `********* announced its next generation *** compiler today. 
// It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***`.

using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string[] text = Console.ReadLine().Split(' ');

        Console.Write("Enter forbidden words, separated by a space: ");
        string[] fWords = Console.ReadLine().Split(' ');

        StringBuilder resultText = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            bool appended = false;
            for (int j = 0; j < fWords.Length; j++)
            {
                if (text[i] == fWords[j])
                {
                    appended = true;
                    resultText.Append(new string('*', fWords[j].Length));
                    break;
                }
            }
            if (!appended)
            {
                resultText.Append(text[i]);
            }
            resultText.Append(" ");
        }
        Console.WriteLine(resultText);
    }
}