using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var donaldIndex = input[input.Count - 1];
            var reserveList = new List<int>();
            reserveList.AddRange(input);

            input.RemoveAt(input.Count - 1);
            var steps = 0;

            for (int i = 0; ; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[j] == 0)
                    {
                        input[j] = reserveList[j];
                    }
                    input[j] -= 1;
                }
                //
                if (i == input.Count - 1)
                {
                    i = 0;
                }



                if (input[donaldIndex] == 0)
                {
                    break;
                }
                donaldIndex = int.Parse(Console.ReadLine());
                steps++;
            }

            Console.WriteLine(string.Join(" ", input));
            Console.WriteLine(steps);
        }
    }
}
