using System;

namespace KilnTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("And what's your sur name?");
            string surName = Console.ReadLine();
            Console.WriteLine("And how old?");
            string howOld = Console.ReadLine();
            Console.Write("Your full name is {0} {1} and age {2}... see you later!", name, surName, howOld);
            Console.ReadLine();
        }
    }
}
