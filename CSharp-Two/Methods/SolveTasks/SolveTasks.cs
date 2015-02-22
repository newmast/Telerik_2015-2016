//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0 using System;

using System;
using System.Threading;
class SolveTasks
{
    static void Main()
    {
        while(true)
        {
            Show();
            Thread.Sleep(40);
            Console.Clear();
        }
    }
    private static string[] mainMenu = { "Reverse digits of a number", 
                                         "Calculate the average of a sequence of integers",
                                         "Solves a linear equation",
                                         "Exit program"};

    private static int currentSelection = 0;
    private static string selector = ">";


    private static void Show()
    {

        PrintMenu(mainMenu);
        HandleInput();
    }

    private static void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.UpArrow)
            {
                currentSelection--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                currentSelection++;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                CheckUserChoice();
            }

            if (currentSelection < 0)
            {
                currentSelection = mainMenu.GetLength(0) - 1;
            }
            else if (currentSelection > mainMenu.GetLength(0) - 1)
            {
                currentSelection = 0;
            }
        }
    }

    private static void CheckUserChoice()
    {
        Console.Clear();
        switch (currentSelection)
        {
            case 0:
                ReverseNumber();
                break;
            case 1:
                AverageOfIntegerSequence();
                break;
            case 2:
                SolveLinearEquation();
                break;
            case 3:
                Environment.Exit(0);
                break;
        }
        Console.WriteLine();
        Console.WriteLine("Press any key to return to menu.");
        Console.ReadKey();
    }

    private static void SolveLinearEquation()
    {
        Console.WriteLine("ax + b = 0");
        Console.Write("Enter value for a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        float b = float.Parse(Console.ReadLine());

        float x = -b / a;

        Console.WriteLine("x is: {0:F2}", x);
    }

    private static void AverageOfIntegerSequence()
    {
        Console.Write("Enter integer amount: ");
        int arrLength = int.Parse(Console.ReadLine());

        int[] values = new int[arrLength];

        for (int i = 0; i < values.GetLength(0); i++)
        {
            Console.Write("[{0}]: ", i);
            values[i] = int.Parse(Console.ReadLine());
        }
        float sum = 0;
        for (int i = 0; i < values.GetLength(0); i++)
        {
            sum += values[i];
        }
        sum /= values.GetLength(0);
        Console.WriteLine("The average sum is: {0:F2}", sum);
    }

    private static void ReverseNumber()
    {
        Console.Write("Enter a number: ");
        string s = Console.ReadLine();
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        Console.Write("The number is: ");
        for (int i = 0; i < charArray.GetLength(0); i++)
        {
            Console.Write(charArray[i]);
        }
    }

    private static void PrintMenu(string[] menu)
    {

        for (int i = 0; i < menu.GetLength(0); i++)
        {
            if (currentSelection == i)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - menu[i].Length / 2 - selector.Length, Console.WindowHeight / 2 + 2 * i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(selector + menu[i]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - menu[i].Length / 2, Console.WindowHeight / 2 + 2 * i);
                Console.Write(menu[i]);
            }
        }
    }
}