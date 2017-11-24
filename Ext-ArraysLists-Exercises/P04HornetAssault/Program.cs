using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P04HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            long hornetsPower = 0;

            for (int i = 0; i < hornets.Count; i++)
            {
                hornetsPower += hornets[i];
            }
            

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                if (hornetsPower <= beehives[i])
                {
                    beehives[i] -= hornetsPower;
                    hornetsPower -= hornets[0];
                    hornets.RemoveAt(0);
                }

                else
                {
                    beehives[i] = 0;
                }
            }

            if (beehives.Contains(0))
            {
                beehives.RemoveAll(x => x == 0);
            }
            

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else 
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
