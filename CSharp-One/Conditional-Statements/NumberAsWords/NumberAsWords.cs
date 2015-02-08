//### Problem 11.* Number as Words
//*	Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

//_Examples:_

//| numbers | number as words               | 
//|---------|-------------------------------|-
//| 0       | Zero                          | 
//| 9       | Nine                          | 
//| 10      | Ten                           | 
//| 12      | Twelve                        | 
//| 19      | Nineteen                      | 
//| 25      | Twenty five                   | 
//| 98      | Ninety eight                  | 
//| 98      | Ninety eight                  | 
//| 273     | Two hundred and seventy three | 
//| 400     | Four hundred                  | 
//| 501     | Five hundred and one          | 
//| 617     | Six hundred and seventeen     | 
//| 711     | Seven hundred and eleven      | 
//| 999     | Nine hundred and ninety nine  |

using System;

class NumberWords
{
    static string OneDigitNumbers(int number)
    {
        string digit;
        switch (number)
        {
            case 0: digit = ""; break;
            case 1: digit = "one"; break;
            case 2: digit = "two"; break;
            case 3: digit = "three"; break;
            case 4: digit = "four"; break;
            case 5: digit = "five"; break;
            case 6: digit = "six"; break;
            case 7: digit = "seven"; break;
            case 8: digit = "eight"; break;
            case 9: digit = "nine"; break;
            default: digit = "";
                break;
        }
        return digit;
    }
    static string TwoDigitNumbers(int number)
    {
        string digit;
        switch (number)
        {
            case 2: digit = "twenty"; break;
            case 3: digit = "thirty"; break;
            case 4: digit = "forty"; break;
            case 5: digit = "fifty"; break;
            case 6: digit = "sixty"; break;
            case 7: digit = "seventy"; break;
            case 8: digit = "eighty"; break;
            case 9: digit = "ninety"; break;
            case 10: digit = "ten"; break;
            case 11: digit = "eleven"; break;
            case 12: digit = "twelve"; break;
            case 13: digit = "thirteen"; break;
            case 14: digit = "fourteen"; break;
            case 15: digit = "fifteen"; break;
            case 16: digit = "sixteen"; break;
            case 17: digit = "seventeen"; break;
            case 18: digit = "eighteen"; break;
            case 19: digit = "nineteen"; break;
            default: digit = "";
                break;
        }
        return digit;
    }

    static void Main()
    {
        Console.Write("Enter a number in the range [0…999]: ");
        int number = int.Parse(Console.ReadLine());

        int count = Convert.ToString(number).Length;
        if (number == 0)
        {
            Console.Write("Number as word: Zero");
        }
        else if (count == 1)
        {
            Console.WriteLine("Number as word: " + OneDigitNumbers(number));
        }
        else if (count == 2)
        {
            if (number < 20)
            {
                Console.WriteLine("Number as word: " + TwoDigitNumbers(number));
            }
            else if (number % 10 == 0)
            {
                string digit = TwoDigitNumbers(number / 10);
                Console.WriteLine("Number as word: " + digit);
            }
            else
            {
                string digit = TwoDigitNumbers(number / 10) + "-" + OneDigitNumbers(number % 10);
                Console.WriteLine("Number as word: " + digit);
            }
        }
        else if (count == 3)
        {
            string digit = OneDigitNumbers(number / 100) + " hundred ";
            if (number / 10 % 10 != 0 || number % 10 != 0)
            {
                digit += "and ";
            }
            if (number % 100 < 20 && number % 100 >= 10)
            {
                digit += TwoDigitNumbers(number % 100);
            }
            else
            {
                if (number % 100 > 20 && number % 10 != 0)
                {
                    digit += TwoDigitNumbers((number % 100) / 10) + "-" + OneDigitNumbers(number % 10);
                }
                else
                {
                    digit += TwoDigitNumbers((number % 100) / 10) + "" + OneDigitNumbers(number % 10);
                }
            }
            Console.WriteLine("Number as words: " + digit);
        }
        Console.WriteLine();
    }
}