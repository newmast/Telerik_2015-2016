//### Problem 4. Compare text files
//*	Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//*	Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        try
        {
            int sameLines = 0;
            int differentLines = 0;
            using (StreamReader firstReader = new StreamReader("../../TextFile1.txt"))
            {

                using (StreamReader secondReader = new StreamReader("../../TextFile2.txt"))
                {
                    while (firstReader.Peek() >= 0)
                    {
                        if (firstReader.ReadLine() == secondReader.ReadLine())
                        {
                            sameLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                    }
                }
            }
            Console.WriteLine("Number of identical lines: " + sameLines);
            Console.WriteLine("Number of different lines: " + differentLines);
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