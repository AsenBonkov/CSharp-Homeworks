using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (commands.Count == 5)
                {
                    var command = commands[0];
                    var startIndex = int.Parse(commands[2]);
                    var count = int.Parse(commands[4]);

                    if (command == "sort")
                    {

                        if (startIndex < 0 || (startIndex + count) > listOfInts.Count || count < 0 || startIndex >= listOfInts.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        var newList = new List<string>();

                        for (int i = startIndex; i < startIndex + count; i++)
                        {
                            newList.Add(listOfInts[i]);
                        }
                        newList.Sort();

                        listOfInts.RemoveRange(startIndex, count);

                        listOfInts.InsertRange(startIndex, newList);
                    }
                    else if (command == "reverse")
                    {
                        if (startIndex < 0 || startIndex >= listOfInts.Count || (startIndex + count) > listOfInts.Count || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        var newList = new List<string>();

                        for (int i = startIndex; i < startIndex + count; i++)
                        {
                            newList.Add(listOfInts[i]);
                        }
                        newList.Reverse();

                        listOfInts.RemoveRange(startIndex, count);

                        listOfInts.InsertRange(startIndex, newList);
                    }
                }
                if (commands.Count == 3)
                {
                    var command = commands[0];
                    var count = int.Parse(commands[1]);

                    var anotherList = new List<string>();

                    if (command == "rollLeft")
                    {
                        for (int i = 0; i < count % listOfInts.Count; i++)
                        {
                            var temp = listOfInts[0];
                            for (int j = 0; j < listOfInts.Count - 1; j++)
                            {
                                listOfInts[i] = listOfInts[i + 1];
                            }
                            listOfInts[listOfInts.Count - 1] = temp;
                        }
                    }
                    if (command == "rollRight")
                    {
                        for (int i = 0; i < count % listOfInts.Count; i++)
                        {
                            var temp = listOfInts[listOfInts.Count - 1];
                            for (int j = listOfInts.Count - 1; j < 0; j--)
                            {
                                listOfInts[i] = listOfInts[i - 1];
                            }
                            listOfInts[0] = temp;
                        }
                    }
                }

            }
            var str = (string.Join(", ", listOfInts));
            Console.WriteLine($"[{str}]");
        }

    }
}
