//Problem 15: Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).﻿

using System;

class NumberCalculations
{
    static T Min<T>(params T[] seq)
    {
        if (seq.Length > 0)
        {
            if (seq.Length == 2)
            {
                dynamic x = seq[0];
                dynamic y = seq[1];
                return x < y ? x : y;
            }
            else
            {
                dynamic result = seq[0];
                for (int i = 1; i < seq.Length; ++i)
                {
                    result = Min(result, seq[i]);
                }
                return result;
            }
        }
        else
        {
            return default(T);
        }
    }

    static T Max<T>(params T[] seq)
    {
        if (seq.Length > 0)
        {
            if (seq.Length == 2)
            {
                dynamic x = seq[0];
                dynamic y = seq[1];
                return x > y ? x : y;
            }
            else
            {
                dynamic result = seq[0];
                for (int i = 1; i < seq.Length; ++i)
                {
                    result = Max<T>(result, seq[i]);
                }
                return result;
            }
        }
        else
        {
            return default(T);
        }
    }

    static T Average<T>(params T[] seq)
    {
        if (seq.Length > 0)
        {
            dynamic counter = 0;
            dynamic sum = 0;
            dynamic sumAvg = 0;
            foreach (var item in seq)
            {
                sum += item;
                counter++;
            }
            sumAvg = sum / counter;
            return sumAvg;
        }
        else
        {
            return default(T);
        }
    }

    static T Sum<T>(params T[] seq)
    {
        dynamic sum = 0;
        foreach (var item in seq)
        {
            sum += item;
        }
        return sum;
    }

    static T Product<T>(params T[] seq)
    {
        if (seq.Length > 0)
        {
            dynamic sum = 1;
            foreach (var item in seq)
            {
                sum *= item;
            }
            return sum;
        }
        else
        {
            return default(T);
        }
    }

    static void Main()
    {
        Console.WriteLine("Numbers: 2, 5, 7");
        Console.WriteLine("Min: {0}", Min(2, 5, 7));
        Console.WriteLine("Max: {0}", Max(2, 5, 7));
        Console.WriteLine("Average: {0}", Average(2.0, 5, 7));
        Console.WriteLine("Sum: {0}", Sum(2, 5, 7));
        Console.WriteLine("Product: {0}", Product(2, 5, 7));
    }
}