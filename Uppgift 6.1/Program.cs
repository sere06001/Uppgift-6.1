using System;
namespace uppgift6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Skriv tal 2: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.Write("Skriv tal 3: ");
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Addera(tal1, tal2, tal3));
            Console.ReadKey();
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
    }
}