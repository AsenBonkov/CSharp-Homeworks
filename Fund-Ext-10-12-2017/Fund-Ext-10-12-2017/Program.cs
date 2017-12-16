using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());

            double regionalCoeficient = 0;
            double coef = 0;

            double totalRegCoef = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                long raindropsCount = Math.Abs(long.Parse(input[0]));
                long squareMeters = long.Parse(input[1]);



                coef = (double)raindropsCount / squareMeters;

                regionalCoeficient += coef;
                totalRegCoef += regionalCoeficient;



            }

            if (density <= 0)
            {
                Console.WriteLine($"{regionalCoeficient:f3}");
            }
            else
            {
                double sum = regionalCoeficient / density;
                Console.WriteLine($"{sum:f3}");
            }
        }
            
    }
}
