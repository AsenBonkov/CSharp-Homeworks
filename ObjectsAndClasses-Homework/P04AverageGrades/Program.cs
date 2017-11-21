namespace P04AverageGrades
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
            var students = new List<Student>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var studentName = input[0];
                var grades = input.Skip(1).Select(double.Parse).ToArray();

                var student = new Student()
                {
                    Name = studentName,
                    Grades = grades
                };

                students.Add(student);

            }

            students = students
                .Where(a => a.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(g => g.AverageGrade)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}
