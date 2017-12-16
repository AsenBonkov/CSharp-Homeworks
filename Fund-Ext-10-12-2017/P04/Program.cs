using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();

            while (true)
            {
                var inputs = Console.ReadLine();
                if (inputs == "I believe I can fly!")
                {
                    break;
                }

                var input = inputs.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (input[1] == "=")
                {
                    var firstName = input[0];
                    var secondName = input[2];
                
                    dict[firstName] = dict[secondName];
                }
                if (input[1] != "=")
                {

                
                    var passName = input[0];
                    if (!dict.ContainsKey(passName))
                    {
                        dict.Add(passName, new List<int>());
                        for (int i = 1; i < input.Count; i++)
                        {
                            int flightNumber = int.Parse(input[i]);
                            dict[passName].Add(flightNumber);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < input.Count; i++)
                        {
                            var flightNumber = int.Parse(input[i]);
                            dict[passName].Add(flightNumber);
                        }
                    }

                }
            }
            foreach (var person in dict.OrderByDescending(a => a.Value.Count)
                .ThenBy(x => x.Key))
            {
                var a = string.Join(", ", person.Value.OrderBy(z => z));
                Console.WriteLine($"#{person.Key} ::: {a}");


            }
        }
    }
}
