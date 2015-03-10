//### Problem 6. Save sorted names
//*	Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

//_Example:_

//|  input.txt |                           | output.txt |
//|:----------:|                           |:----------:|
//| Ivan <br> Peter <br> Maria <br> George | George <br> Ivan <br> Maria <br> Peter |

using System;
using System.Collections.Generic;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        var names = new List<string>();
        using (StreamReader reader = new StreamReader("../../input.txt"))
        {
            while (reader.Peek() >= 0)
            {
                names.Add(reader.ReadLine());
            }
        }
        names.Sort();
        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            foreach (var name in names)
            {
                writer.WriteLine(name);
            }
        }
    }
}