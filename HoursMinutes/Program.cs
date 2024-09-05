using System.Collections.Generic;
using System;

namespace HoursMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9.Timmar / minuter(SVÅRARE)

            //Skapa ett program där användaren matar in ett antal minuter (minst 60 minuter).
            //Programmet omvandlar sedan detta till timmar och minuter.

            //a.Skriv in ”Mata in antal minuter:”
            //b.Ta emot detta tal
            //c.Räkna om detta till antal timmar och minuter
            //d.Skriv ut på skärmen-Detta är... timmar och ... minuter

            Console.Write("Mata in antal minuter: ");
            // option 1
            int minutes = int.Parse(Console.ReadLine());

            // option 2
            // int minutes = Convert.ToInt32(Console.ReadLine());

            // option 3 -> TryParse (Googla!)
            // xxxxxxxxxxxxxxxxxxx


            if (minutes < 60)
            {
                Console.WriteLine("Du måste mata in minst 60 minuter.");
                // Vad gör return?
                return;
            }

            int hours = minutes / 60;
            
            // %? Wtf!
            int remainingMinutes = minutes % 60;

            // Vad heter det när vi använder $ på detta sätt?
            Console.WriteLine($"Detta är {hours} timmar och {remainingMinutes} minuter.");

            // Gör om denna rad med concatination
            Console.WriteLine($"Detta är {hours} timmar och {remainingMinutes} minuter.");
        }
    }
}
