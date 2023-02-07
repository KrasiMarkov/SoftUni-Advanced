using System;
using System.Collections.Generic;
using System.Linq;
namespace Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Cat> cats = new List<Cat>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(", ").ToArray();

                string name = line[0];

                int age = int.Parse(line[1]);

                Cat cat = new Cat();
                cat.Name = name;
                cat.Age = age;

                cats.Add(cat);

            }

            string condition = Console.ReadLine();

            int ageCondition = int.Parse(Console.ReadLine());

            var outPutFormat = Console.ReadLine();

            Func<Cat, bool> myFunc = cat => true;

            if (condition == "older")
            {
                myFunc = c => c.Age >= ageCondition;
            }

            else if (condition == "younger")
            {
                myFunc = c => c.Age < ageCondition;
            }

            cats = cats.Where(myFunc).ToList();

            var result = new List<string>();

            if (outPutFormat == "name age")
            {
                result = cats.Select(c => $"{c.Name} - {c.Age}").ToList();
            }

            else if (outPutFormat == "name")
            {
                result = cats.Select(c => c.Name).ToList();
            }

            else if (outPutFormat == "age")
            {
                result = cats.Select(c => c.Age.ToString()).ToList();
            }

            result.ForEach(Console.WriteLine);
        }


    }
   
}
