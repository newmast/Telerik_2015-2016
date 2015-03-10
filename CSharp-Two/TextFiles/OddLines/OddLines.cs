//### Problem 1. Odd lines
//*	Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("../../OddLinesText.txt"))
            {
                int i = 1;
                while (reader.Peek() >= 0)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                    else
                    {
                        reader.ReadLine();
                    }
                    i++;
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