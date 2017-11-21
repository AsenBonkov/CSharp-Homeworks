namespace P03AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var goods = new Dictionary<string, int>();

            var input = Console.ReadLine();
            

            while (input != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());

                if (goods.ContainsKey(input))
                {
                    goods[input] += quantity;
                }
                else
                {
                    goods.Add(input, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var item in goods)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
