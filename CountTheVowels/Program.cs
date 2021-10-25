using System;
using System.Text.RegularExpressions;

namespace CountTheVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of vowels in 'Abacus': ");
            CountVowels("Abacus");
            Console.WriteLine();

            Console.Write("Number of vowels in 'AmErIcA': ");
            CountVowels("AmErIcA");
            Console.WriteLine();

            Console.Write("Number of vowels in 'ttttttt': ");
            CountVowels("ttttttt");
            Console.WriteLine();

            Console.ReadKey();
        }


        static void CountVowels(string input)
        {
            Regex rx = new Regex("[aeiou]", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(input);
            Console.Write(matches.Count);
        }
    }
}
