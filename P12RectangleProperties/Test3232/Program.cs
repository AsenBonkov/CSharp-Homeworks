using System;

namespace Test3232
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (a > 5)
                {
                    Console.WriteLine("Yes");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
