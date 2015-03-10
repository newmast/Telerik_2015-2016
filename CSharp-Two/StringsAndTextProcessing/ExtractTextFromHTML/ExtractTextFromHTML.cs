//### Problem 25. Extract text from HTML
//*	Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

//_Example input:_

//    <html>
//      <head><title>News</title></head>
//      <body><p><a href="http://academy.telerik.com">Telerik
//        Academy</a>aims to provide free real-world practical
//        training for young people who want to turn into
//        skilful .NET software engineers.</p></body>
//    </html>

//_Output:_ 

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

using System;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Enter HTML code: ");
        string text = Console.ReadLine();
        Console.WriteLine();
        MatchCollection tags = Regex.Matches(text, @"((?<=^|>)[^><]+?(?=<|$))");
        int count = 1;

        foreach (Match tag in tags)
        {
            if (count == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Title: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}", tag);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Text: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(tag + " ");
            }
            count++;
        }
        Console.WriteLine();
    }
}