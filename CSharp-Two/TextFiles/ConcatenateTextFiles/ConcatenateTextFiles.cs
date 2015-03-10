//### Problem 2. Concatenate text files
//*	Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        try
        {
            StringBuilder fileContent = new StringBuilder();
            using (StreamReader reader = new StreamReader("../../TextFile1.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    fileContent.Append(reader.ReadLine() + Environment.NewLine);
                }
            }
            using (StreamReader reader = new StreamReader("../../TextFile2.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    fileContent.Append(reader.ReadLine() + Environment.NewLine);
                }
            }
            using (StreamWriter writer = new StreamWriter("../../TextFileResult.txt"))
            {
                writer.Write(fileContent);                
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