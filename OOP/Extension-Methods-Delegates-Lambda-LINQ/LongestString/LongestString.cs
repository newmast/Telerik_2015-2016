using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class LongestString
    {
        static void Main()
        {
            Console.WriteLine("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            string[] words = new string[length];

            for (int i = 0; i < length; i++)
            {
                words[i] = Console.ReadLine();
            }
            string longestWord = words.OrderByDescending(x => x.Length).ToArray()[0];

            Console.WriteLine("Longest word: " + longestWord);
        }
    }
}
