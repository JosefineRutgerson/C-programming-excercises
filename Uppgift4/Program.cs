using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.4
            guessGame();
            Console.ReadKey();
        }

        private static void guessGame()
        {
            Console.WriteLine("Hi, I'm thinking about a number between 1 and 100, can you guess what it is?");
            string guessNumber = Console.ReadLine();
            int guess = Int32.Parse(guessNumber);
            Random randomNumberGenerator = new Random();
            int computerChoice = randomNumberGenerator.Next(1, 100);
            int count = 1;
            int lastGuess = 0;
            int gameover = 7;
            bool start = true;

            while (start)
            {
                if (guess == computerChoice)
                {
                    Console.WriteLine("You guessed correct! But you needed " + count + " guesses ");
                    break;
                }
                else if (count >= gameover)
                {
                    Console.WriteLine("Mohahaha, that's gameover for you cuz you don't get more than " + count + " guesses");
                    break;
                }

                else if (guess > computerChoice)
                {
                    
                    Console.WriteLine(" Wrong! Your number " + guess + " is to high, guess again");
                    
                }

                else if (guess < computerChoice)
                {
                    Console.WriteLine("Wrong! Your guess " + guess + " is to low, guess again");
                                        
                }

                lastGuess = guess;
                guessNumber = Console.ReadLine();
                guess = Int32.Parse(guessNumber);
                if (lastGuess != guess)
                {
                    count = count + 1;
                }

            }

        }

    }
}
