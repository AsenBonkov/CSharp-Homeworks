using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07MaxSeqOfIncrElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int lenght = 0;
            int max = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] - numbers[i] >= 1)
                {
                    lenght++;
                    if (lenght > max)
                    {
                        start = i - lenght;
                        max = lenght;
                    }
                }
                else
                {
                    lenght = 0;
                }
            }
            for (int i = start + 1; i <= start + max + 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
