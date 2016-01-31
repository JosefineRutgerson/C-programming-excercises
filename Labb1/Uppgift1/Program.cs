using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1
            int[] numbersarray = new int[7] { 2, 12, 6, 8, 10, 4, 14 };

            findNumber(numbersarray);
            Console.ReadKey();
        }
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
                        
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            Console.WriteLine("The max number is " + maxNumber);
            Console.WriteLine("The lowest number is " + minNumber);
        }
    }
}
