using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            numbers = numbers.Take(arr[0]).ToList();
            //for (int i = arr[0]; i < numbers.Count; i++)
            //{
            //    numbers.RemoveAt(arr[0]);
            //}

            numbers.RemoveRange(0, arr[1]);
            
            //for (int i = 0; i < arr[1]; i++)
            //{
            //    numbers.RemoveAt(0);
            //}

            //bool result = false;

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == arr[2])
            //    {
            //        result = true;
            //    }
            //}

            if (numbers.Contains(arr[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            
        }
    }
}
