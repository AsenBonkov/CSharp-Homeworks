﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int mostFrequentNumbr = 0;
            int repetitions = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int counter = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        counter++;
                    }

                }

                if (counter > repetitions)
                {
                    mostFrequentNumbr = currentNumber;
                    repetitions = counter;
                }
            }

            Console.WriteLine("{0}", mostFrequentNumbr);
        }
    }
}
