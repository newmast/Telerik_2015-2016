//### Problem 16.	Decimal to Hexadecimal Number
//*	Using loops write a program that converts an integer number to its hexadecimal representation.
//*	The input is entered as long. The output should be a variable of type string.
//*	Do not use the built-in .NET functionality.

//_Examples:_

//| decimal      | hexadecimal |
//|--------------|-------------|
//| 254          | FE          |
//| 6883         | 1AE3        |
//| 338583669684 | 4ED528CBB4  |

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decNumber = long.Parse(Console.ReadLine());

        string hexNumber = "";

        if (decNumber == 0)
        {
            hexNumber = "0";
        }
        else
        {
            while (decNumber > 0)
            {
                long remain = decNumber % 16;
                decNumber /= 16;

                switch (remain)
                {
                    case 10: 
                        hexNumber +="A"; 
                        break;    
                    case 11:      
                        hexNumber +="B"; 
                        break;    
                    case 12:      
                        hexNumber +="C"; 
                        break;    
                    case 13:      
                        hexNumber +="D"; 
                        break;    
                    case 14:      
                        hexNumber +="E"; 
                        break;    
                    case 15:      
                        hexNumber +="F"; 
                        break;
                    default: 
                        hexNumber += remain;
                        break;
                }
            }
        }
        Console.WriteLine("Its hexadecimal representation: " + hexNumber);
    }
}
