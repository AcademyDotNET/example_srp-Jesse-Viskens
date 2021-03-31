using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Hello World!\"");
            string name = "Jesse";
            int j = 1;
            MyFirstMethod(name);
            MyFirstMethod(j);
        }
        static void MyFirstMethod(int name)
        {
            Console.WriteLine(name);
            Console.ReadLine();
        }
        static void MyFirstMethod(string name)
        {
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
