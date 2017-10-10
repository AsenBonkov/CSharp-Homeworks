using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();


            if (firstArr.Length == secondArr.Length)
            {
                if (firstArr[0] < secondArr[0])
                {
                    Console.WriteLine($"{string.Join("", firstArr)}");
                    Console.WriteLine($"{string.Join("", secondArr)}");
                }
                else
                {
                    Console.WriteLine($"{string.Join("", secondArr)}");
                    Console.WriteLine($"{string.Join("", firstArr)}");
                }
            }
            else if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine($"{string.Join("", secondArr)}");
                Console.WriteLine($"{string.Join("", firstArr)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("", firstArr)}");
                Console.WriteLine($"{string.Join("", secondArr)}");
            }

        }
    }
}
