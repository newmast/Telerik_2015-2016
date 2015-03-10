//### Problem 3. Line numbers
//*	Write a program that reads a text file and inserts line numbers in front of each of its lines.
//*	The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        try
        {
            var textFile = new List<string>();
            using (StreamReader reader = new StreamReader("../../TextFile1.txt"))
            {
                int i = 1;
                while (reader.Peek() >= 0)
                {
                    textFile.Add(i + ". ");
                    textFile.Add(reader.ReadLine() + Environment.NewLine);
                    i++;
                }
            }
            using (StreamWriter writer = new StreamWriter("../../TextFile2.txt"))
            {
                foreach (var element in textFile)
                {
                    writer.Write(element);
                }
            }
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (EndOfStreamException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}