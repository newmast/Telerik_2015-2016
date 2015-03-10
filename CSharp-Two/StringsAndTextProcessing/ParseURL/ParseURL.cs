//### Problem 12. Parse URL
//*	Write a program that parses an URL address given in the format: 
// `[protocol]://[server]/[resource]` and extracts from it the `[protocol]`, `[server]` and `[resource]` elements.

//_Example:_ 

//|                 URL                  |                                     Information                                     |
//|:------------------------------------:|:----------------------------------------------------------------------------------------:|
//| `http://telerikacademy.com/Courses/Courses/Details/212` |
// [protocol] = `http` <br> [server] = `telerikacademy.com` <br> [resource] = `/Courses/Courses/Details/212` |

using System;
using System.Text;

class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL: ");
        string[] url = Console.ReadLine().Split(new string[] {"://", "/"}, StringSplitOptions.None );

        string protocol = url[0];
        string server = url[1];
        StringBuilder resource = new StringBuilder();
        resource.Append('/');
        for (int i = 2; i < url.Length; i++)
        {
            resource.Append(url[i]);
            resource.Append('/');
        }
        Console.WriteLine("Protocol: " + protocol);
        Console.WriteLine("Server: " + server);
        Console.WriteLine("Resource: " + resource);
    }
}