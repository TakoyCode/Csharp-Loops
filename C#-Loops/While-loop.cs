using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Loops
{
    internal class While_loop
    {
        // While-løkker bruker man når man vil utføre kodehandlinger så lenge en "condition" har boolean verdien true.

        // I kodesnutten under setter man en bool variabel kalt condition verdien true
        // Deretter lager man en whileløkke som vil kjøre så lenge condition har verdien true.

        public void WhileLoopExample()
        {
            bool condition = true;
            int i = 0;

            while (condition)
            {
                if (i < 10) // dersom i er mindre en 10 printer vi ut at Terje er kul, og øker i med 1
                {
                    Console.WriteLine("Terje er Kul");
                    i++;
                }
                else
                {
                    condition = false; // når denne linjen har kjørt vil løkken avsluttes
                }
            }

            // Konsollen vil da logge ut:
            // "Terje er kul" 10 ganger

        }

    }
}
