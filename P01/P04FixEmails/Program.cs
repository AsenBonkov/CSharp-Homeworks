namespace P04FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input1 = Console.ReadLine();

            var emails = new Dictionary<string, string>();

            while (input1 != "stop")
            {
                var input2 = Console.ReadLine();

                if (!(input2.EndsWith("us") || input2.EndsWith("uk")))
                {
                emails.Add(input1, input2);
                }


                input1 = Console.ReadLine();

            }
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }



        }
    }
}
