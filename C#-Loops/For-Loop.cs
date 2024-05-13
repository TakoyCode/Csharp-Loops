using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Loops
{
    internal class For_Loop
    {
        // De tre mest brukte løkken vi har er for-løkken, for-each-løkken og while-løkken.
        // Felles for løkker er at de kjører samme kodelinjer flere ganger frem til man har oppnådd det man vil.

        // FOR-LØKKE

        // For løkke brukker vi oftest når vi vil gjenta noe et spesifikt antall ganger
        // eller behøver en indeks for å prosessere dataene våre.
        public void ForLoopExample()
        {
            string[] args = new string[] { "dette", "er", "gøy" };
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            } 
        }

        // I denne koden definerer vi et nytt array av typen string som blir 3 elementer lang.
        // Deretter defineres en for-løkke der vi lager en midlertidig variable av typen int vi kaller "i".
        // Vi sier at så lenge "i" er mindre enn lengden på arrayet som heter args(i < 3) så skal vi printe ut det som befinner seg på indeks-verdien.

        // Konsollen vi da logge ut:
        // dette
        // er
        // gøy
    }
}
