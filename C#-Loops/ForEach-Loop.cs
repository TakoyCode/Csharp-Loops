using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Loops
{
    internal class ForEach_Loop
    {
        // Når vi ikke er så opptatt av hvilken index vi er på, og ikke bryr oss om antall ganger vi skal gjøre noe
        // men heller vil gjøre noe per element i et array eller i en liste, bruker vi noe som heter foreach:

        public void ForEachExample()
        {
            string[] args = new string[] { "dette", "er", "gøy" };
            
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }

        // Her lager vi en midler tidig variabel vi kaller arg som vil representere hvert enkelt element som finnes i args, runde for runde.
        // I dette tilfellet har vi 3 elementer i arrayet, slik at arg får følgende verdier:

        // Første runde blir arg = "dette", andre runde blir arg = "er", og siste runde blir arg = "gøy".
        
        // Konsolen vil da logge ut:
        // dette 
        // er
        // gøy


    }
}
