
using System;

class IntegerCalculations
{
    static int Min(params int[] seq)
    {
        if (seq.Length > 0)
        {
            if (seq.Length == 2)
            {
                int x = seq[0];
                int y = seq[1];
                return x < y ? x : y;
            }
            else
            {
                int result = seq[0];
                for (int i = 1; i < seq.Length; ++i)
                {
                    result = Min(result, seq[i]);
                }
                return result;
            }
        }
        return 0;
    }

    static int Max(params int[] seq)
    {
        if (seq.Length > 0)
        {
            if (seq.Length == 2)
            {
                int x = seq[0];
                int y = seq[1];
                return x > y ? x : y;
            }
            else
            {
                int result = seq[0];
                for (int i = 1; i < seq.Length; ++i)
                {
                    result = Max(result, seq[i]);
                }
                return result;
            }
        }
        return 0;
    }

    static float Average(params int[] seq)
    {
        if (seq.Length > 0)
        {
            int counter = 0;
            float sum = 0;
            float sumAvg = 0;
            foreach (var item in seq)
            {
                sum += item;
                counter++;
            }
            sumAvg = sum / counter;
            return sumAvg;
        }
        return 0;
    }

    static int Sum(params int[] seq)
    {
        int sum = 0;
        foreach (var item in seq)
        {
            sum += item;
        }
        return sum;
    }

    static int Product(params int[] seq)
    {
        if (seq.Length > 0)
        {
            int sum = 1;
            foreach (var item in seq)
            {
                sum *= item;
            }
            return sum;
        }
        return 0;
    }

    static void Main()
    {
        Console.WriteLine("Numbers: 2, 5, 7");
        Console.WriteLine("Min: {0}", Min(2, 5, 7));
        Console.WriteLine("Max: {0}", Max(2, 5, 7));
        Console.WriteLine("Average: {0}", Average(2, 5, 7));
        Console.WriteLine("Sum: {0}", Sum(2, 5, 7));
        Console.WriteLine("Product: {0}", Product(2, 5, 7));
    }
}