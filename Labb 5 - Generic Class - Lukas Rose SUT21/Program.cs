using System;

namespace Labb_5___Generic_Class___Lukas_Rose_SUT21
{
    class Program
    {
        static void Main(string[] args)
        {
            IntCheck<int> ic1 = new IntCheck<int>();
            IntCheck<int> ic2 = new IntCheck<int>();
            StringCheck<string> sc1 = new StringCheck<string>();
            StringCheck<string> sc2 = new StringCheck<string>();

            Console.WriteLine($"Resultat av att jämföra om 102 är lika med 102: {ic1.ToCheck(102, 102)}");
            Console.WriteLine($"Resultat av att jämföra om 167 är lika med 102: {ic2.ToCheck(167, 102)}");
            Console.WriteLine($"Resultat av att jämföra om \"Mandarin\" är lika med \"Clementin\": {sc1.ToCheck("Mandarin", "Clementin")}");
            Console.WriteLine($"Resultat av att jämföra om \"Apelsin\" är lika med \"Apelsin\": {sc2.ToCheck("Apelsin", "Apelsin")}");
            Console.ReadLine();
        }
    }
}
