using System;

namespace P13VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'o') || (symbol == 'u') ||
                (symbol == 'e') || (symbol == 'i'))
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
            Console.WriteLine();
        }
    }
}
