using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.3

            //string[] CalcArray = new string[3] { "5", "*", "2" };

            float numberOne;
            float numberTwo;

            float.TryParse(args[0], out numberOne); // converts the args to int, gives the new int value to "nomberOne" by the out keyword.
            float.TryParse(args[2], out numberTwo);

            //numberOne = float.Parse(args[0]);
            //multiply(numberOne, numberTwo);

            if (args[1] == "+")
            {
                Console.WriteLine(addition(numberOne, numberTwo));
            }
            if (args[1] == "-")
            {
                
                Console.WriteLine(subtract(numberOne, numberTwo));
            }
            if (args[1] == "*")
            {
                
                Console.WriteLine(multiply(numberOne, numberTwo));
            }
            if (args[1] == "/")
            {
                Console.WriteLine(divide(numberOne, numberTwo));
            }

            Console.ReadKey();
        }

        private static float divide(float numberOne, float numberTwo)
        {
            float sum = numberOne - numberTwo;
            return sum;
        }

        private static float subtract(float numberOne, float numberTwo)
        {
            float sum = numberOne - numberTwo;
            return sum;
        }

        private static float addition(float numberOne, float numberTwo)
        {
            float sum = numberOne + numberTwo;
            return sum;
        }

        private static float multiply(float numberOne, float numberTwo)
        {
            float sum = numberOne * numberTwo;
            return sum;
        }

        private static void multiply(string[] args)
        {
            
        }

        
    }
}
