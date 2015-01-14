//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? integerValue = null;
        double? doubleValue = null;
        Console.WriteLine("After first task:");
        Console.WriteLine("Null integer = {0}\nNull double = {1}\n", integerValue, doubleValue);

        integerValue += 5;
        doubleValue += null;

        Console.WriteLine("After second task:");
        Console.WriteLine("Null integer = {0}\nNull double = {1}\n", integerValue, doubleValue);
    }
}

