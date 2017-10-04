using System;

namespace P14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            string hex = number.ToString("X");
           

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
