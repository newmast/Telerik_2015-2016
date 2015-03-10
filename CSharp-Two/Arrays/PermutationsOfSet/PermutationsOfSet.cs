//### Problem 19.* Permutations of set
//*	Write a program that reads a number `N` and generates and prints all the permutations of the numbers [`1 � N`].

//_Example:_

//| N |                                  result                                 |
//|:-:|:-----------------------------------------------------------------------:|
//| 3 | `{1, 2, 3}` `{1, 3, 2}` `{2, 1, 3}` `{2, 3, 1}` `{3, 1, 2}` `{3, 2, 1}` |

using System;

class PermutationsOfSet
{
    static int[] permutations;
    static int n = 0;

    static void Main()
    {
        Console.Write("Enter a number N: ");
        n = int.Parse(Console.ReadLine());

        permutations = new int[n];

        for (int i = 0; i < n; i++)
        {
            permutations[i] = i + 1;
        }
        DetermineVariants(0, n - 1);
    }

    static void DetermineVariants(int currentNumber, int length)
    {
        if (currentNumber == length)
        {
            printArray();
        }
        else
        {
            int temp = 0;
            for (int i = currentNumber; i <= length; i++)
            {
                temp = permutations[i];
                permutations[i] = permutations[currentNumber];
                permutations[currentNumber] = temp;

                DetermineVariants(currentNumber + 1, length);

                temp = permutations[i];
                permutations[i] = permutations[currentNumber];
                permutations[currentNumber] = temp;
            }
        }

    }

    static void printArray()
    {
        Console.Write("{" + permutations[0]);
        for (int i = 1; i < n; i++)
        {
            Console.Write(", " + permutations[i]);
        }
        Console.WriteLine("}");
    }
}
