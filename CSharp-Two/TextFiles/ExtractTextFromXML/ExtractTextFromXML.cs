//### Problem 10. Extract text from XML
//*	Write a program that extracts from given XML file all the text without the tags.
//_Example:_
//`<?xml version="1.0">
//<student>
//  <name>Pesho</name>
//  <age>21</age>
//      <interests count="3">
//          <interest>Games</interest>
//          <interest>C#</interest>
//          <interest>Java</interest>
//      </interests>
//</student>`

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class ExtractTextFromXML
{
    const char SPACE = ' ';
    static void Main(string[] args)
    {
        var info = new List<string>();
        using (StreamReader reader = new StreamReader("../../input.txt"))
        {
            string xml = reader.ReadToEnd();
            info.Add(GetResult(xml));
            
        }
        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            foreach (var information in info)
            {
                writer.WriteLine(information);
            }
        }
    }

    static string GetResult(string xml)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder current = new StringBuilder();
        bool insideTag = false;

        foreach (var letter in xml)
        {
            if (insideTag)
            {
                if (letter == '>')
                {
                    insideTag = false;
                }
                continue;
            }
            else
            {
                if (letter == '<')
                {
                    if (current.Length > 0)
                    {
                        result.AppendLine(current.ToString());
                        current.Clear();
                    }
                    insideTag = true;
                }
                else
                {
                    current.Append(letter);
                }
                continue;
            }
        }
        return result.ToString();
    }
}