using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        string input = "";
        BigInteger numberInput = 0;
        BigInteger productOfNumbers = 1;
        BigInteger productOfNumbersAfter10 = 1;

        int i = 0;
        while (true)
        {
            input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            numberInput = BigInteger.Parse(input);
            if (i <= 10)
            {
                if (i % 2 == 1)
                {
                    productOfNumbers *= calcDigitProduct(numberInput);
                }
            }
            else
            {
                if (i % 2 == 1)
                {
                    productOfNumbersAfter10 *= calcDigitProduct(numberInput);
                }
            }
            
            i++;
        }
        Console.WriteLine(productOfNumbers);
        if (i > 10)
        {
            Console.WriteLine(productOfNumbersAfter10);
        }
    }

    static BigInteger calcDigitProduct(BigInteger number)
    {
        if (number == 0)
        {
            return 1;
        }
        BigInteger digitProduct = 1;

        while (number > 0)
        {
            BigInteger temp = number % 10;
            if (temp != 0)
            {
                digitProduct *= temp;
            }
            number /= 10;
        }

        return digitProduct;
    }
}
