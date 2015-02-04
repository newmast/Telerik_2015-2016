using System;

class SearchInBits
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        bool[] sBits = new bool[4];

        for (int i = 0; i < 4; i++)
        {
            sBits[i] = ((s >> i) & 1) != 0;
        }

        bool[,] nBits = new bool[n, 30];

        for (int i = 0; i < n; i++)
        {
            uint number = uint.Parse(Console.ReadLine());

            for (int j = 0; j < 30; j++)
            {
                nBits[i, j] = ((number >> j) & 1) != 0;
            }
        }

        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 27; j++)
            {
                if (nBits[i, j] == sBits[0] &&
                    nBits[i, j + 1] == sBits[1] &&
                    nBits[i, j + 2] == sBits[2] &&
                    nBits[i, j + 3] == sBits[3])
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);

    }
}
