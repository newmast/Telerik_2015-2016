﻿//### Problem 10.* Beer Time
//*	A beer time is after `1:00 PM` and before `3:00 AM`.
//*	Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//  and prints `beer time` or `non-beer time` according to the definition above or `invalid time` if the time cannot be parsed.
//_Note: You may need to learn how to parse dates and times._ 

//_Examples:_

//| time     | result        |
//|----------|---------------|
//| 1:00 PM  | beer time     |
//| 4:30 PM  | beer time     |
//| 10:57 PM | beer time     |
//| 8:30 AM  | non-beer time |
//| 02:59 AM | beer time     |
//| 03:00 AM | non-beer time |
//| 03:26 AM | non-beer time |

using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time: ");

        DateTime time = DateTime.Parse(Console.ReadLine());

        if (time.Hour >= 13 || time.Hour < 3)
        {
            Console.WriteLine("It is beer time.");
        }
        else
        {
            Console.WriteLine("It isn't beer time... yet.");
        }
        }
    }
    }
}
