//### Problem 1. Say Hello
//*	Write a method that asks the user for his name and prints `�Hello, <name>�`
//*	Write a program to test this method.

//_Example:_

//| input |     output    |
//|:-----:|:-------------:|
//| Peter | Hello, Peter! |

using System;

class SayHello
{
    static void Main()
    {
        Hello("Peter");
    }
    static void Hello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}

