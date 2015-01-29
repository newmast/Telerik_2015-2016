//### Problem 9. Play with Int, Double and String
//*	Write a program that, depending on the user’s choice, inputs an `int`, `double` or `string` variable.
//    *	If the variable is `int` or `double`, the program increases it by one.
//    *	If the variable is a `string`, the program appends `*` at the end.
//*	Print the result at the console. Use switch statement.

//_Example 1:_

//| program                | user  |
//|------------------------|-------|
//| Please choose a type:  |       |
//| 1 --> int              |       |
//| 2 --> double           | 3     |
//| 3 --> string           |       |
//|                        |       |
//| Please enter a string: | hello |
//|                        |       |
//| hello*                 |       |

//_Example 2:_

//| program                | user |
//|------------------------|------|
//| Please choose a type:  |      |
//| 1 --> int              |      |
//| 2 --> double           | 2    |
//| 3 --> string           |      |
//|                        |      |
//| Please enter a double: | 1.5  |
//|                        |      |
//| 2.5                    |      |

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int choseInt = int.Parse(Console.ReadLine());
                Console.WriteLine(++choseInt);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double choseDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(++choseDouble);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string choseString = Console.ReadLine();
                Console.WriteLine(choseString + "*");
                break;
            default:
                Console.WriteLine("Please enter a valid input!");
                break;
        }
    }
}
