using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 1.2

        Console.WriteLine("To end the application, write 'END'");
        List<string> stringList = new List<string>(); // Declare a new list named "stringList"
        String savedValues;
        bool start = true;

        while (start)
        {
            savedValues = Console.ReadLine(); 

            if (savedValues != "END")
            {
            stringList.Add(savedValues); // as long as the user don't write "END", the different strings that the user writes will be added to my list "stringList"

            }
            else // else = when the user writes "END"
            {
                start = false;

            }

        }

        for (int i = stringList.Count -1; i >= 0; i--) // Decrements the list, i(count) = 3, i-1 = position 2. 
        {
            Console.Write(stringList[i] + ", ");

        }

        Console.ReadKey();
        }
    }
}
