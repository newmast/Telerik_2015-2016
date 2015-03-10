//### Problem 9. Delete odd lines
//*	Write a program that deletes from given text file all odd lines.
//*	The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        var lines = new List<string>();
        using (StreamReader reader = new StreamReader("../../deleteOddLines.txt"))
        {                                            
            int i = 1;                               
            while (!reader.EndOfStream)              
            {                                        
                if (i % 2 == 1)                      
                {                                    
                    lines.Add(reader.ReadLine());    
                }
                else
                {
                    reader.ReadLine();
                }
                i++;                                 
            }                                        
        }
        File.WriteAllText("../../deleteOddLines.txt", string.Empty);
        using (StreamWriter writer = new StreamWriter("../../deleteOddLines.txt"))
        {
            foreach (var line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }
}