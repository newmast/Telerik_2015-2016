//Problem 12.** Falling Rocks

//Implement the "Falling Rocks" game in the text console.

//A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;
using System.Threading;
using System.Collections.Generic;

class FallingRocks
{
    static bool playing = true;
    static char[] dwarf = { '(', '0', ')' };
    static int dwarfPositionX = Console.WindowWidth / 2 - 1;

    static char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-'};
    static int rockID = 0;
    static int amountOfRocksOnLine = 0;
    static int rockCoordinatesX = 0;

    static Random rockPicker = new Random();
    static Random colorPicker = new Random();

    static List<char> fallingRocks = new List<char>();
    static List<int> fallingRocksCoordsX = new List<int>();
    static List<int> fallingRocksCoordsY = new List<int>();

    static int score = 0;
    static int destroyedRocks = 0;
    static int destroyedRocksCounter = 0;
    static bool addScore = false;

    static void Main()
    {
        ConfigureWindowSettings();

        while (playing)
        {
            if (Console.KeyAvailable)
            {
                MoveThePlayer();
            }
            Console.Clear();
            GenerateRocks();
            SpawnRocks();
            DrawScore();
            DrawDwarf();
            CheckCollison();
            Thread.Sleep(100);
        }
        EndScreen();
    }

    static void EndScreen()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine();
        pickEndMessage();
        Console.WriteLine("Your score was: " + score);
        Console.WriteLine("You successfully dodged " + destroyedRocksCounter + " rocks.");
        Console.ReadLine();
    }

    static void pickEndMessage()
    {
        if (score < 100)
        {
            Console.WriteLine("You did poorly!");
        }
        else if(score < 200)
        {
            Console.WriteLine("You can do better!"); 
        }
        else if (score < 500)
        {
            Console.WriteLine("You need just a little bit more practice!");
        }
        else if (score < 1000)
        {
            Console.WriteLine("Getting better!");
        }
        else if (score < 2000)
        {
            Console.WriteLine("Good job!");
        }
        else if (score < 3000)
        {
            Console.WriteLine("You did really good!");
        }
        else if (score < 5000)
        {
            Console.WriteLine("Amazing job!");
        }
        else if (score < 7500)
        {
            Console.WriteLine("You are exceptional at this.");
        }
        else if (score >= 7500)
        {
            Console.WriteLine("You have been playing this for way too long. 10/10.");
        }
    }

    static void DrawScore()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 8);
        Console.Write(score);
    }

    static void CheckCollison()
    {

        destroyedRocks = destroyedRocksCounter;
        for (int i = destroyedRocks; i < fallingRocks.Count; i++)
        {
            if ((dwarfPositionX == fallingRocksCoordsX[i] ||
                 dwarfPositionX + 1 == fallingRocksCoordsX[i] ||
                 dwarfPositionX + 2 == fallingRocksCoordsX[i]) &&
                fallingRocksCoordsY[i] == Console.WindowHeight - 2)
            {
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                playing = false;
            }
        }
    }

    static void SpawnRocks()
    {
        addScore = false;

        destroyedRocks = destroyedRocksCounter;
        for (int i = destroyedRocks; i < fallingRocks.Count; i++)
        {
            fallingRocksCoordsY[i]++;

            if (fallingRocksCoordsY[i] < Console.WindowHeight)
            {
                Console.SetCursorPosition(fallingRocksCoordsX[i], fallingRocksCoordsY[i]);
                pickColor(i);
                Console.Write(fallingRocks[i]);
            }
            else
            {
                // TODO: Optimization
                destroyedRocksCounter++;
                addScore = true;
            }
        }
        if (addScore)
        {
            score++;
        }
    }

    static void pickColor(int i)
    {
        switch (fallingRocks[i])
        {
            case '^':
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                break;
            case '@':
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                break;
            case '*':
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case '&':
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            case '+':
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                break;
            case '%':
                Console.ForegroundColor = ConsoleColor.DarkRed;
                break;
            case '$':
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                break;
            case '#':
                Console.ForegroundColor = ConsoleColor.DarkRed;
                break;
            case '!':
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                break;
            case '.':
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            case ';':
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                break;
        }
    }

    static void GenerateRocks()
    {
        amountOfRocksOnLine = rockPicker.Next(1, 5);
        destroyedRocks += amountOfRocksOnLine;

        for (int i = 0; i < amountOfRocksOnLine; i++)
        {
            rockID = rockPicker.Next(0, 12);
            fallingRocks.Add(rocks[rockID]);

            rockCoordinatesX = rockPicker.Next(0, Console.WindowWidth);
            fallingRocksCoordsX.Add(rockCoordinatesX);
            fallingRocksCoordsY.Add(0);
        }
    }

    static void ConfigureWindowSettings()
    {
        Console.Title = "Falling Rocks";
        Console.BackgroundColor = ConsoleColor.White;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static void MovePlayerLeft()
    {
        if (dwarfPositionX > 0)
        {
            dwarfPositionX--;
        }
    }

    static void MovePlayerRight()
    {
        if (dwarfPositionX <= Console.WindowWidth - 3 - 1)
        {
            dwarfPositionX++;
        }
    }

    static void DrawDwarf()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(dwarfPositionX, Console.WindowHeight - 2);
        for (int i = 0; i < 3; i++)
        {
            Console.Write(dwarf[i]);
        }
    }

    static void MoveThePlayer()
    {
        ConsoleKeyInfo PressedKey = Console.ReadKey();

        if (PressedKey.Key == ConsoleKey.LeftArrow)
        {
            MovePlayerLeft();
        }
        else if (PressedKey.Key == ConsoleKey.RightArrow)
        {
            MovePlayerRight();
        }
    }
}