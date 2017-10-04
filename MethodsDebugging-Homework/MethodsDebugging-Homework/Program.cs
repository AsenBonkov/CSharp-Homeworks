using System;

namespace MethodsDebugging_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
        }
        static void PrintName()
        {
            string name = "Peter";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
