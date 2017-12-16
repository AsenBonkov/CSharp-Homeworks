using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool typ = false;
            bool forec = false;
            bool sour = false;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Davai Emo")
                {
                    break;
                }
                
                var typePattern = @"^Type: (Normal|Danger|Warning)$";
                var sourcePattern = @"^Source: ([A-Za-z0-9]+)$";
                var forecastPattern = @"^Forecast: ([^!\.,?]+?)$";

                var regex = new Regex(typePattern);
                if (regex.IsMatch(input))
                {
                    Console.Write(regex.Match(input));
                }
                var regex1 = new Regex(sourcePattern);
                if (regex1.IsMatch(input))
                {
                    Console.Write(regex1.Match(input));
                }
                var regex2 = new Regex(forecastPattern);
                if (regex2.IsMatch(input))
                {
                    Console.WriteLine(regex2.Match(input));
                }
                


                
                
            }
        }
    }
}
