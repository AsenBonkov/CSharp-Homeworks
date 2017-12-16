using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var placeholders = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]+)(.*)(\1)";

            var matches = Regex.Matches(input, pattern);

            var count = 0;

            foreach (Match item in matches)
            {
                var newStr = item.Groups[1] + placeholders[count++] + item.Groups[3];
                input = input.Replace(item.Value, newStr);
            }
            Console.WriteLine(input);
        }
    }
}
