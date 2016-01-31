using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 1.7

            int[] secondLargestArray = new int[7] { 12, 14, 3, 9, 8, 6, 13 };

            findSecondLargestNumber(secondLargestArray);
            Console.ReadKey(); 
        }
        // 1.7

        private static void findSecondLargestNumber(int[] secondLargestArray)
        {
            int highestNumber = int.MinValue;
            int secondHighest = int.MinValue;

            foreach (int item in secondLargestArray)
            {
                if (item > highestNumber)
                {
                    secondHighest = highestNumber;
                    Console.WriteLine("This is the value of the variable secondHigest " + secondHighest);
                    highestNumber = item;
                    Console.WriteLine("This is the value of the variable highestNumber " + highestNumber);
                }
                else if (item > secondHighest)
                {
                    secondHighest = item;
                }
            }

            Console.WriteLine("The second largest number is " + secondHighest);

        }
    }
}
