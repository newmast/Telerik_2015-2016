using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('#', i));
            Console.Write(new string('\\', 1));

            if (2 * n - 3 - 2 * d - 2 * i >= 0)
            {
                Console.Write(new string(' ', d));
                Console.Write(new string('\\', 1));
                Console.Write(new string('.', 2 * n - 3 - 2 * d - 2 * i));
                Console.Write(new string('/', 1));
                Console.Write(new string(' ', d));
            }
            else
            {
                Console.Write(new string(' ', 2 * n + 1- 2 * i - 2));
            }

            Console.Write(new string('/', 1));
            Console.Write(new string('#', i));
            Console.WriteLine();
        }

        Console.Write(new string('#', n));
        Console.Write(new string('X', 1));
        Console.Write(new string('#', n));
        Console.WriteLine();

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(new string('#', i));
            Console.Write(new string('/', 1));

            if (2 * n - 3 - 2 * d - 2 * i >= 0)
            {
                Console.Write(new string(' ', d));
                Console.Write(new string('/', 1));
                Console.Write(new string('.', 2 * n - 3 - 2 * d - 2 * i));
                Console.Write(new string('\\', 1));
                Console.Write(new string(' ', d));
            }
            else
            {
                Console.Write(new string(' ', 2 * n + 1 - 2 * i - 2));
            }

            Console.Write(new string('\\', 1));
            Console.Write(new string('#', i));
            Console.WriteLine();
        }
    }
}
