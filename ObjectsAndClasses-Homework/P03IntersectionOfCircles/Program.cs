namespace P03IntersectionOfCircles
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
            var x1x2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var y1y2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            
        }
    }
    public class Circle
    {
        public int Center { get; set; }
        public int Radius { get; set; }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }  
    }
}
