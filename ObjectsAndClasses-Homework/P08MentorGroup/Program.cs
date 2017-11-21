namespace P08MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<Student>();

            while (input != "end of dates")
            {
                var dictionary = new Dictionary<string, DateTime>();
                var names = input.Split(' ', ',');
                
            }
            
        }
    }
    public class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Attendance { get; set; }
    }
}
