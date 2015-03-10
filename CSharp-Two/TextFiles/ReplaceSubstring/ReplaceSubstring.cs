//### Problem 7. Replace sub-string
//*	Write a program that replaces all occurrences of the sub-string `start` with the sub-string `finish` in a text file.
//*	Ensure it will work with large files (e.g. `100 MB`).

using System;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../before.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../after.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string currentLine = reader.ReadLine();
                    currentLine = currentLine.Replace("start", "finish");
                    writer.WriteLine(currentLine);
                }
            }
        }
    }
}