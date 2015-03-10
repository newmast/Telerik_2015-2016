﻿//### Problem 3. Read file contents
//*	Write a program that enters file name along with its full file path (e.g. `C:\WINDOWS\win.ini`), reads its contents and prints it on the console.
//*	Find in MSDN how to use `System.IO.File.ReadAllText(�)`.
//*	Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        string filePath = @"C:\WINDOWS\win.ini";

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("The file does not exist!");
        }
        
        try
        {
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine(fileContents);
        }
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DriveNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}