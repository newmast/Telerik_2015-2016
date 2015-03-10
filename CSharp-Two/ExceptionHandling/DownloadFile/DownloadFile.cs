//### Problem 4. Download file
//*	Write a program that downloads a file from Internet (e.g. [Ninja image](http://telerikacademy.com/Content/Images/news-img01.png)) and 
//* stores it the current directory.
//*	Find in Google how to download files in C#.
//*	Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        using (WebClient fileDownloader = new WebClient())
        {
            try
            {
                Console.WriteLine("Downloading...");
                fileDownloader.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png" , "news-img01.png");
                Console.WriteLine("File successfully downloaded.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}