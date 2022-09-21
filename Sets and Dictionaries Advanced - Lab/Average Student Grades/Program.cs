using System;
using System.Linq;
using System.Collections.Generic;
namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {

                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = info[0];

                decimal grade = decimal.Parse(info[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }

                students[name].Add(grade);
            }

            foreach (var item in students)
            {
                Console.Write($"{item.Key} -> ");

                foreach (var itemm in item.Value)
                {
                    Console.Write($"{itemm:F2} ");

                }
                Console.WriteLine($"(avg: {item.Value.Average():F2})");
                
            }
        }
    }
}
