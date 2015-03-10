//### Problem 8. Extract sentences
//*	Write a program that extracts from a given text all sentences containing given **word**.
//_Example:_
//_The word is:_ **in**
//_The text is:_ We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
// So we are drinking all the day. We will move out of it in 5 days.
//_The expected result is:_ We are living in a yellow submarine. We will move out of it in 5 days.
//_Consider that the sentences are separated by `.` and the words – by **non-letter symbols**._

using System;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter a key: ");
        string key = Console.ReadLine();

        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        string[] sentences = text.Split(new string[] { ". " }, StringSplitOptions.None);

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(" " + key))
            {
                if (sentences[i][sentences[i].IndexOf(key) + key.Length - 1] < 'a' ||
                    sentences[i][sentences[i].IndexOf(key) + key.Length - 1] > 'A' ||
                    sentences[i][sentences[i].IndexOf(key) + key.Length - 1] < 'z' ||
                    sentences[i][sentences[i].IndexOf(key) + key.Length - 1] > 'Z')
                {
                    if (i != sentences.Length - 1)
                    {
                        Console.Write(sentences[i] + ". ");
                    }
                    else
                    {
                        Console.Write(sentences[i]);
                    }
                }
            }
        }
        Console.WriteLine();
    }
}