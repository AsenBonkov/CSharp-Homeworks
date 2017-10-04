using System;

namespace DataTypesAndVariables_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = (2 * height) + (2 * width);
            double diagonal = Math.Sqrt((width * width) + (height * height));            

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
