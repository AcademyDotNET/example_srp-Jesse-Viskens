using System;

namespace Rommel_zin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je favoriete eten?");
            string eten = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete auto?");
            string auto = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete boek?");
            string boek = Console.ReadLine();

            Console.WriteLine("Wat is je favoriete kleur?");
            string kleur = Console.ReadLine();


            Solution1(eten,auto,boek,kleur);
            Solution2(eten, auto, boek, kleur);

            Console.ReadLine();
        }
        public static void Solution1(string eten, string auto, string boek, string kleur)
        {
            Console.WriteLine($"Je favoriete kleur is {eten}. Je eet graag {auto}. Je lievelingsfilm is {boek} en je favoriete boek is {kleur}.");

            var j = 122.5D;
            var d = (double)125;
            Console.WriteLine($"{eten}");
        }
        public static void Solution2(string eten, string auto, string boek, string kleur)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Je favoriete kleur is {eten}.");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Je eet graag {auto}.");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je lievelingsfilm is {boek}.");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"je favoriete boek is {kleur}.");

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
