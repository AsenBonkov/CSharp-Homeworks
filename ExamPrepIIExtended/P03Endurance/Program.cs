using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Endurance
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Select(double.Parse).Select(Math.Abs).ToArray();
            var checkPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var p in participants)
            {
                var fuel = (double)p[0];
                var i = 0;
                while (i < zones.Length && fuel > 0)
                {




                    i++;
                }
            }


        }
    }
}
