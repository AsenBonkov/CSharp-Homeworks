namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        { 
            var phonebook = Console.ReadLine();
            
            var dict = new Dictionary<string, string>();

            while (phonebook != "END")
            {
                string[] command = phonebook.Split(' ').ToArray();

                if (command[0] == "S")
                {
                    if (!dict.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} -> {dict[command[1]]}");
                    }
                }
                else
                {
                    dict[command[1]] = command[2];
                }

                phonebook = Console.ReadLine();
            }
            
                
        }
    }
}
