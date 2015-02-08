//### Problem 4.	Print a Deck of 52 Cards
//*	Write a program that generates and prints all possible cards from a [standard deck of 52 cards] (without the jokers).
//    The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//    *	The card faces should start from 2 to A.
//    *	Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
//    Use 2 nested for-loops and a switch-case statement.
	
//_Example:_

//    2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//    3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//    …  
//    K of spades, K of clubs, K of hearts, K of diamonds
//    A of spades, A of clubs, A of hearts, A of diamonds

//_Note: You may use the suit symbols instead of text._

using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i < 11; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(i + " ");
                switch (j)
                {
                    case 0:
                        Console.Write("of spades");
                        break;
                    case 1:
                        Console.Write("of clubs");
                        break;
                    case 2:
                        Console.Write("of hearts");
                        break;
                    case 3:
                        Console.Write("of diamonds");
                        break;
                }

                if (j != 3)
                {
                    Console.Write(", ");  
                }                                            
            }
            Console.WriteLine();                                                       
        }

        char card = 'J';

        for (int i = 0; i < 4; i++)
        {
            switch (i)
            {                                              
                case 1:
                    card = 'Q';                           
                    break;                                                  
                case 2:
                    card = 'K';                               
                    break;                                                  
                case 3:
                    card = 'A';                                                     
                    break;  
            }
            for (int j = 0; j < 4; j++)
            {
                Console.Write(card + " ");
                switch (j)
                {
                    case 0:
                        Console.Write("of spades");
                        break;
                    case 1:
                        Console.Write("of clubs");
                        break;
                    case 2:
                        Console.Write("of hearts");
                        break;
                    case 3:
                        Console.Write("of diamonds");
                        break;
                }

                if (j != 3)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

