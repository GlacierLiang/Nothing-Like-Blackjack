using System;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                Deck deck = new Deck();
                // DON'T SHUFFLE THE DECK

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card c11 = deck.TakeTopCard();
                Card c21 = deck.TakeTopCard();
                Card c31 = deck.TakeTopCard();
                Card c41 = deck.TakeTopCard();

                Card c12 = deck.TakeTopCard();
                Card c22 = deck.TakeTopCard();
                Card c32 = deck.TakeTopCard();
                Card c42 = deck.TakeTopCard();

                // deal 1 more card to players 2 and 3
                Card c23 = deck.TakeTopCard();
                Card c33 = deck.TakeTopCard();

                // flip all the cards over
                c11.FlipOver();
                c12.FlipOver();

                c21.FlipOver();
                c22.FlipOver();
                c23.FlipOver();

                c31.FlipOver();
                c32.FlipOver();
                c33.FlipOver();

                c41.FlipOver();
                c42.FlipOver();

                // print the cards for player 1
                Console.WriteLine(c11.Rank + "," + c11.Suit);
                Console.WriteLine(c12.Rank + "," + c12.Suit);

                // print the cards for player 2
                Console.WriteLine(c21.Rank + "," + c21.Suit);
                Console.WriteLine(c22.Rank + "," + c22.Suit);
                Console.WriteLine(c23.Rank + "," + c23.Suit);

                // print the cards for player 3
                Console.WriteLine(c31.Rank + "," + c31.Suit);
                Console.WriteLine(c32.Rank + "," + c32.Suit);
                Console.WriteLine(c33.Rank + "," + c33.Suit);

                // print the cards for player 4
                Console.WriteLine(c41.Rank + "," + c41.Suit);
                Console.WriteLine(c42.Rank + "," + c42.Suit);

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
