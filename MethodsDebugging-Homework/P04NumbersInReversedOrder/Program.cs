using System;

namespace P04NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReversedNumber(number));
        }

        static string ReversedNumber(string number)
        {
            string result = "";

            for (int i = number.Length - 1; i >= 0; i++)
            {
                result += number[i];
            }

            return result;
        }
    }
}
