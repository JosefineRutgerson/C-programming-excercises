using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Labb 1.5

            int[] arraySum = new int[5] { 1, 2, 3, 4, 5 }; // sum = 15

            //sumWhile(arraySum);
            Console.WriteLine("The sum of the array is " + sumRecur(arraySum, 4));
            //Console.ReadKey();
            forSum(arraySum);

        }
        // 1.5

        // While loop sum
        private static void sumWhile(int[] arraySum)
        {
            int sum = 0;
            int i = 0;

            while (i < arraySum.Length)
            {
                sum += arraySum[i];
                i++;
            }
            Console.WriteLine("the sum of the array numbers is " + sum);
            Console.ReadKey();
        }

        ////Recursive sum
        private static int sumRecur(int[] arraySum, int position)
        {

            if (position == 0)
            {
                //  Console.WriteLine(arraySum[position]);
                Console.WriteLine("The value of position " + position + " is " + arraySum[position]);
                return arraySum[0];
            }
            Console.WriteLine("The value of position " + position + " is " + arraySum[position]);
            //Console.WriteLine(arraySum[position] + sumRecur(arraySum, position - 1));
            return arraySum[position] + sumRecur(arraySum, position - 1);
            


        }

        ////For loop sum
        private static void forSum(int[] arraySum)
        {
            int sum = 0;
            for (int i = 0; i < arraySum.Length; i++)
            {
                sum += arraySum[i];
                Console.WriteLine("the value of position " + i + " is " + arraySum[i]);

            }
            Console.WriteLine("this is the sum of the array " + sum);
            Console.ReadKey();
        }

        // exampl of an recursiva method..

        /*public static double facto(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * facto(number - 1);
        }*/
    }
}
