//### Problem 18. Extract e-mails
//*	Write a program for extracting all email addresses from given text.
//*	All sub-strings that match the format `<identifier>@<host>…<domain>` should be recognized as emails.

using System;

class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string[] text = Console.ReadLine().Split(' ');

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains("@"))
            {
                Console.WriteLine("E-mail: " + text[i]);
            }
        }
    }
}