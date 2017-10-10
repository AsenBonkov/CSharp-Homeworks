using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = Console.ReadLine().ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine($"{characters[i]} -> {characters[i] - 97}");
            }
        }
    }
}
