using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift6
{
    class Program
    {
        static void Main(string[] args)
        {

            // labb 1.6


            List<int> numberList = new List<int> ();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(6);

            //returnOddNumber(numberList);

            int[] arrayWithNumbers = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            findOddNumber(arrayWithNumbers);
            //int[] thirdArray = findOddNumber(arrayWithNumbers);
           
            Console.ReadKey();
        }

        private static List<int> returnOddNumber(List<int> numberList)
        {
            int listL = numberList.Count;
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();


            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    oddList.Add(numberList[i]);
                    
                }
                else
                {
                    evenList.Add(numberList[i]);
                }
            }
                return oddList;
        }

        // 1.6
        private static int[] findOddNumber(int[] Numbers)
        {
            int aLength = Numbers.Length;
            int[] oddNumbers = new int[aLength / 2 + aLength % 2];

            for (int i = 0; i < aLength; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers[i] = Numbers[i];
                    Console.WriteLine(oddNumbers[i] + ", ");
                }

                    }

                   return oddNumbers;


            }
    }
}
