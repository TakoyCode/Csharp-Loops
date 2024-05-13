using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Loops
{
    internal class Oppgaver
    {
        public void Run()
        {
            //ForTerjeIsCool();
            //PrintLetters();
            GetRound();
        }

        // Oppgave 1: Lag en for-løkke som printer "Terje er kul" til konsollen 5 ganger
        void ForTerjeIsCool()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul");
            }
        }

        // Oppgave 2:
        // Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen.
        // Hint: en string kan brukes på samme måte som et array!
        void PrintLetters()
        {
            string sentence = "Dette er en setning";
            foreach(char letter in sentence)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine();

            char[] word = new[] { 'o', 'r', 'd', };
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
        }

        // Oppgave 3:
        // Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10
        void GetRound()
        {
            int roundcounter = 1;
            bool raceIsGoing = true;
            while (raceIsGoing)
            {
                Console.WriteLine($"Runde nummer {roundcounter}");
                roundcounter++;
                if (roundcounter >= 10) raceIsGoing = false;
            }

        }


    }
}
