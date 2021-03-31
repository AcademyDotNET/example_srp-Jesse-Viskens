
using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {       
            string name = UserInput();
            MijnEersteMethode(name);
        }
        public static string UserInput()
        {
            Console.WriteLine("Geef uw naam");
            string name = Console.ReadLine();
            return name;
        }
        public static void MijnEersteMethode(string name)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
