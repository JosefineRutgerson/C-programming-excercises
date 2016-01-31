using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 1.8

            orgel();
        }

        // Labb 1.8

        private static void orgel()
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
            const int Fhalf5 = 739;
            
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
               
                
            }

        }
    }
}
