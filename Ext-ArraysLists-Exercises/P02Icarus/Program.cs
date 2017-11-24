namespace P02Icarus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            int[] plane = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startingPoint = int.Parse(Console.ReadLine());

            int initialDmg = 1;

            var commands = Console.ReadLine();

            while (commands != "Supernova")
            {
                var command = commands.Split();

                var direction = command[0];
                var steps = int.Parse(command[1]);
                for (int i = 0; i < steps; i++)
                {
                    if (direction == "right")
                    {
                        if (startingPoint >= plane.Length - 1)
                        {
                            startingPoint = -1;
                            initialDmg++;
                        }
                        plane[startingPoint + 1] -= initialDmg;
                        startingPoint++;
                        
                    }
                    if (direction == "left")
                    {
                        if (startingPoint <= 0)
                        {
                            startingPoint = plane.Length;
                            initialDmg++;
                        }
                        plane[startingPoint - 1] -= initialDmg;
                        startingPoint--;
                        
                    }
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", plane));
        }

    }
}
