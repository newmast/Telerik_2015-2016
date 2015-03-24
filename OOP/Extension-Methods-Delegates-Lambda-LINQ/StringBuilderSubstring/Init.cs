//### Problem 1. StringBuilder.Substring
//*	Implement an extension method `Substring(int index, int length)` for the class `StringBuilder`
//* that returns new `StringBuilder` and has the same functionality as `Substring` in the class `String`.

namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    class Init
    {
        static void Main()
        {
            StringBuilder printer = new StringBuilder();
            printer.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.WriteLine(printer.Substring(2, 4));
        }
    }
}
