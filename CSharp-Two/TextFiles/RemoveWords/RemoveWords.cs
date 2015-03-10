//### Problem 12. Remove words
//*	Write a program that removes from a text file all words listed in given another text file.
//*	Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;

class RemoveWords
{
    static void Main()
    {
        var forbiddenWords = new List<string>();
        var result = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader("../../WordList.txt"))
            {
                while (!reader.EndOfStream)
                {
                    forbiddenWords.Add(reader.ReadLine());
                }
            }

            using (StreamReader reader = new StreamReader("../../Result.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string currentLine = reader.ReadLine();

                    foreach (var element in forbiddenWords)
                    {
                        if (currentLine.Contains(element))
                        {
                            result.Add(currentLine.Remove(currentLine.IndexOf(element), element.Length));
                        }
                    }
                }
            }

            File.WriteAllText("../../Result.txt", string.Empty);

            using (StreamWriter writer = new StreamWriter("../../Result.txt"))
            {
                foreach (var element in result)
                {
                    writer.WriteLine(element);
                }
            }
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentNullException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}