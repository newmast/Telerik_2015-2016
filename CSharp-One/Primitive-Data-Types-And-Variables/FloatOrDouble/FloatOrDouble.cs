﻿//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstNum = 34.567839023;
        double secondNum = 8923.1234857;

        float thirdNum = 12.345f;
        float fourthNum = 3456.091f;

        Console.WriteLine("Doubles: {0} and {1}", firstNum, secondNum);
        Console.WriteLine("Floats: {0} and {1}", thirdNum, fourthNum);
    }
}
