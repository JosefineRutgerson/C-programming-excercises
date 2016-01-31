using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Csharplabb1
{
    class Program
    {
        // Labb 1.1
        private static void findNumber(int[] numbers)
        {
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++) // Loops through the array "numbers" during the lenght of the array
            {
                if (numbers[i] > maxNumber) // If the value of position i in the array is bigger than the value of maxNumber
                {
                    maxNumber = numbers[i]; // maxNumber is assigned the value of the position i
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine("The max number is " + maxNumber);
            Console.WriteLine("The lowest number is " + minNumber);            
        }

        static void Main(string[] args)
        {

            // Lab 1.8

            //orgel();


            // Lab 1.7

            //int[] secondLargestArray = new int[6] { 2, 4, 6, 8, 9, 10 };

            //findSecondLargestNumber(secondLargestArray);


            // labb 1.6

            //int[] arrayWithNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //findOddNumber(arrayWithNumbers);
            //int[] thirdArray = findOddNumber(arrayWithNumbers);


            //Labb 1.5

            //int[] arraySum = new int[5] { 1, 2, 3, 4, 5 }; // sum = 15

            //sumWhile(arraySum);
            //sumRecur(arraySum, 4);
            //forSum(arraySum);

            // 1.4
            //guessGame();

            // 1.3

            //string[] CalcArray = new string[3] { "5", "*", "2" };

            //float numberOne;
            //float numberTwo;

            //float.TryParse(args[0], out numberOne);
            //float.TryParse(args[2], out numberTwo);


            //if (args[1] == "+")
            //{
            //    float add = numberOne + numberTwo;
            //    Console.WriteLine("the answer is " + add);
            //}
            //if (args[1] == "-")
            //{
            //    float subtract = numberOne - numberTwo;
            //    Console.WriteLine("The answer is " + subtract);
            //}
            //if (args[1] == "*")
            //{
            //    float multiply = numberOne * numberTwo;
            //    Console.WriteLine("The answer is " + multiply);
            //}
            //if (args[1] == "/")
            //{
            //    float divide = numberOne / numberTwo;
            //    Console.WriteLine("The answer is " + divide);
            //}

            //Console.ReadKey();


            // 1.2

            //Console.WriteLine("To end the application, write 'END'");
            //List<string> stringList = new List<string>(); // Declare a new list named "stringList"
            //String savedValues;
            //bool start = true;

            //while (start)
            //{
            //    savedValues = Console.ReadLine(); 

            //    if (savedValues != "END")
            //    {
            //    stringList.Add(savedValues); // as long as the user don't write "END", the different strings that the user writes will be added to my list "stringList"

            //    }
            //    else // else = when the user writes "END"
            //    {
            //        start = false;

            //    }

            //}

            //for (int i = stringList.Count; i > 0; i--) // Decrements the list, i(count) = 3, i-1 = position 2. 
            //{
            //    Console.Write(stringList[i-1] + ", ");

            //}

            //Console.ReadKey();

            // 1.1
            //int[] numbersarray = new int[7] { 2, 12, 6, 8, 10, 4, 14 };

            //findNumber(numbersarray);
            //Console.ReadKey();
        }

        // Labb 1.8

        /*private static void orgel()
        {
           
            int C4 = 261;
            int Chalf4 = 277;
            int D4 = 293;
            int Dhalf4 = 311;
            int E4 = 329;            
            int F4 = 349;
            int Fhalf4 = 369;
            int G4 = 392;
            int Ghalf4 = 415;
            int A4 = 440;
            int Ahalf4 = 466;
            int B4 = 493;
            int C5 = 523;
            int Chalf5 = 554;
            int D5 = 587;
            int Dhalf5 = 622;
            int E5 = 659;
            int F5 = 698;            
            int Fhalf5 = 739;
            
            Console.WriteLine("Which tune?");
            ConsoleKey key = Console.ReadKey().Key;
            bool start = true;

            while (start)
            {
                key = Console.ReadKey().Key;
                

                if (key == ConsoleKey.A)
                {
                    Console.Beep(C4, 200);

                }
                else if (key == ConsoleKey.W) 
                {
                    Console.Beep(Chalf4, 200);
                    
                }
                else if (key == ConsoleKey.S)
                {
                    Console.Beep(D4, 200);
                    
                }
                else if (key == ConsoleKey.E)
                {
                    Console.Beep(Dhalf4, 200);
                    
                }
                else if (key == ConsoleKey.D)
                {
                    Console.Beep(E4, 200);

                }
                else if (key == ConsoleKey.F)
                {
                    Console.Beep(F4, 200);
                    
                }
                else if (key == ConsoleKey.T)
                {
                    Console.Beep(Fhalf4, 200);
                    
                }
                else if (key == ConsoleKey.G)
                {
                    Console.Beep(G4, 200);
                    
                }
                else if (key == ConsoleKey.Y)
                {
                    Console.Beep(Ghalf4, 200);
                    
                }
                else if (key == ConsoleKey.H)
                {
                    Console.Beep(A4, 200);
                    
                }
                else if (key == ConsoleKey.U)
                {
                    Console.Beep(Ahalf4, 200);
                    
                }
                else if (key == ConsoleKey.J)
                {
                    Console.Beep(B4, 200);
                    
                }
                else if (key == ConsoleKey.K)
                {
                    Console.Beep(C5, 200);
                    
                }
                else if (key == ConsoleKey.O)
                {
                    Console.Beep(Chalf5, 200);
                    
                }
                else if (key == ConsoleKey.L)
                {
                    Console.Beep(D5, 200);
                    
                }
                else if (key == ConsoleKey.P)
                {
                    Console.Beep(Dhalf5, 200);
                    
                }
                else if (key == ConsoleKey.Oem3)
                {
                    Console.Beep(E5, 200);
                    
                }
                else if (key == ConsoleKey.Oem7)
                {
                    Console.Beep(F5, 200);
                    
                }
                else if (key == ConsoleKey.Oem6)
                {
                    Console.Beep(Fhalf5, 200);
                    
                }
                else if (key == ConsoleKey.Escape)
                {
                    start = false;
                }
                else
                {
                    
                    key = Console.ReadKey().Key;
                }
                
            }

        }*/

        // 1.7

        //private static void findSecondLargestNumber(int[] secondLargestArray)
        //{
        //    int highestNumber = int.MinValue;
        //    int secondHighest = int.MinValue;

        //    foreach (int item in secondLargestArray)
        //    {
        //        if (item > highestNumber)
        //        {
        //            secondHighest = highestNumber;
        //            highestNumber = item;
        //        }
        //        else if (item > secondHighest)
        //        {
        //            secondHighest = item;
        //        }
        //    }

        //    Console.WriteLine(secondHighest);

        //}

        // 1.6
        //private static int[] findOddNumber(int[] Numbers)
        //{
        //    int[] oddNumbers = new int[numbers.Length / 2 + 1];

        //    for (int i = 0; i < Numbers.Length; i++)
        //    {
        //        if (Numbers[i] % 2 != 0)
        //        {

        //            for (int j = 0; j < oddNumbers.Length; j++)
        //            {
        //                oddNumbers[j] = Numbers[i];
        //                Console.Write(i.ToString() + ", ");
        //            }
        //        }

        //    }

        //       return oddNumbers;


        //}

        // 1.5

        // While loop sum
        //private static void sumWhile(int[] arraySum)
        //{
        //    int sum = 0;
        //    int i = 0;

        //    while (i < arraySum.Length)
        //    {
        //        sum += arraySum[i];
        //        i++;
        //    }
        //    Console.WriteLine(sum);
        //    Console.ReadKey();
        //}

        ////Recursive sum
        //private static int sumRecur(int[] arraySum, int position)
        //{

        //    if (position == 0)
        //    {
        //        //  Console.WriteLine(arraySum[position]);
        //        return arraySum[0];
        //    }
        //    //Console.WriteLine(arraySum[position]);
        //    Console.WriteLine(arraySum[position] + sumRecur(arraySum, position - 1));
        //    return arraySum[position] + sumRecur(arraySum, position - 1);


        //}

        ////For loop sum
        //private static void forSum(int[] arraySum)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arraySum.Length; i++)
        //    {
        //        sum += arraySum[i];
                
        //    }
        //    Console.WriteLine(sum);
        //}

        // exampl of an recursiva method..

        /*public static double facto(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * facto(number - 1);
        }*/



        // 1.4

        /*private static void guessGame()
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
                    start = false;
                }
                else if (count >= gameover)
                {
                    Console.WriteLine("Mohahaha, that's gameover for you cuz you don't get more than " + count + " guesses");
                    start = false;
                }

                else if (guess > computerChoice)
                {
                    lastGuess = guess;
                    Console.WriteLine(" Wrong! Your number " + guess + " is to high, guess again");
                    guessNumber = Console.ReadLine();
                    guess = Int32.Parse(guessNumber);
                    if (lastGuess != guess)
                    {
                        count = count + 1;
                    }
                }

                else if (guess < computerChoice)
                {
                    lastGuess = guess;
                    Console.WriteLine("Wrong! Your guess " + guess + " is to low, guess again");
                    guessNumber = Console.ReadLine();
                    guess = Int32.Parse(guessNumber);
                    if (lastGuess != guess)
                    {
                        count = count + 1;
                    }
                }
            }

        }*/













        






    }

    //private static int recursive(int[] sumArray, int n)
    //{


    //    if (n == 1)
    //    {
    //        return sumArray[0];
    //    }
    //    else
    //    {
    //        return n + recursive(sumArray, n - 1);


    //    }
    //}


}

