using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Loops
{
    internal class LoopsVideo
    {
        public void Run()
        {
            //WhileLoop();
            //DoWhile();
            //ForEach();
            ForLoop();
        }

        // While løkke
        void WhileLoop()
        {
            bool shouldRun = true;
            int i = 0;
            while (shouldRun)
            {
                if (i > 19) shouldRun = false;
                Console.WriteLine($"Heio i verdi {i}");
                i++;
            }
        }

        // Do while løkke - Kjører altid en gang selv om while er false
        void DoWhile()
        {
            do
            {
                Console.WriteLine("Hei");
            } while (true);
        }

        // Foreach
        void ForEach()
        {
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            foreach (int number in numberArray)
            {
                Console.WriteLine(number);
            }

        }

        // for-loop
        void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i er: {i}");
            } 
        }


    }
}
