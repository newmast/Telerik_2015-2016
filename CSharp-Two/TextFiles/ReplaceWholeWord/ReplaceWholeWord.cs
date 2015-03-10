//### Problem 8. Replace whole word
//*	Modify the solution of the previous problem to replace only **whole words** (not strings).

using System;
using System.IO;

class ReplaceWholeWord
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
                    for (int i = currentLine.IndexOf("start"); i != -1; i = currentLine.IndexOf("start", i + 1))
                    {
                        if ((i - 1 < 0 || !Char.IsLetter(currentLine[i - 1])) && 
                            (i + 5 >= currentLine.Length) || 
                            !Char.IsLetter(currentLine[i + 5]))
                        {
                            currentLine = currentLine.Insert(i, "finish").Remove(i + 6, 5);
                        }
                    }
                    writer.WriteLine(currentLine);
                }
            }
        }
    }
}