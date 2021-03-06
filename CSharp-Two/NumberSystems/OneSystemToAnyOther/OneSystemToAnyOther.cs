﻿using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter current base: ");
        int baseFrom = int.Parse(Console.ReadLine());
        Console.Write("Enter a number in base " + baseFrom + ": ");
        string number = Console.ReadLine();
        Console.Write("Enter base to convert to: ");
        int baseTo = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} (base {1}) is equal to {2} (base {3})",
            number, baseFrom,
            DecimalToAnyBase(ConvertToDecimal(number, baseFrom), baseTo), baseTo);
    }

    public static int ConvertToDecimal(string str, int numberBase)
    {
        int v = 0;
        int total = 0;
        int pow = 0;
        str = str.ToUpper();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            char c = str[i];
            if (c >= '0' && c <= '9')
                v = c - '0';
            else if (c >= 'A' && c <= 'Z')
                v = 10 + (c - 'A');
            total += v * (int)Math.Pow(numberBase, pow);
            pow++;
        }
        return total;
    }
    public static string DecimalToAnyBase(long decimalNumber, int radix)
    {
        const int BitsInLong = 64;
        const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        if (radix < 2 || radix > Digits.Length)
            throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

        if (decimalNumber == 0)
            return "0";

        int index = BitsInLong - 1;
        long currentNumber = Math.Abs(decimalNumber);
        char[] charArray = new char[BitsInLong];

        while (currentNumber != 0)
        {
            int remainder = (int)(currentNumber % radix);
            charArray[index--] = Digits[remainder];
            currentNumber = currentNumber / radix;
        }

        string result = new String(charArray, index + 1, BitsInLong - index - 1);
        if (decimalNumber < 0)
        {
            result = "-" + result;
        }

        return result;
    }
}