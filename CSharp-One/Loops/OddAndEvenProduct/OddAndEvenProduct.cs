//### Problem 10.	Odd and Even Product
//*	You are given `n` integers (given in a single line, separated by a space).
//*	Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//*	Elements are counted from `1` to `n`, so the first element is odd, the second is even, etc.

//_Examples:_

//| numbers           | result |
//|-------------------|--------|
//| 2 1 1 6 3         | yes    |
//| product = 6       |        |
//|                   |        |
//| 3 10 4 6 5 1      | yes    |
//| product = 60      |        |
//|                   |        |
//| 4 3 2 5 2         | no     |
//| odd_product = 16  |        |
//| even_product = 15 |        |

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter some integers, separated by a space: ");
        string[] numbers = Console.ReadLine().Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0) // if uncountable
            {
                oddProduct *= int.Parse(numbers[i]);
            }
            else // if countable
            {
                evenProduct *= int.Parse(numbers[i]);
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("The two products are equal.");
        }
        else
        {
            Console.WriteLine("The two products aren't equal.");
        }
    }
}
