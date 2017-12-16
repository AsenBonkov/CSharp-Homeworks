using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictStandings = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (true)
            {
                if (input == "end")
                {
                    break;
                }

                var arr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = arr[1];
                var points = int.Parse(arr[6]);

                if (!dictStandings.ContainsKey(name))
                {
                    dictStandings.Add(name, points);
                }
                else if (dictStandings.ContainsKey(name))
                {
                    dictStandings[name] += points;
                }
                
            }
            var i = 1;
            foreach (var person in dictStandings.OrderBy(e => e.Value))
            {
                Console.WriteLine($"{i}.{person.Key} ------- {person.Value}");
                i++;
            }
        }
    }
}
