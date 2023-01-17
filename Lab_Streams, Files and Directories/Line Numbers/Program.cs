using System;
using System.IO;
namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("TextFileOne.txt", FileMode.OpenOrCreate);

            FileStream otherStream = new FileStream("TextFileTwo.txt", FileMode.OpenOrCreate);

            using StreamReader reader = new StreamReader(stream);

            using StreamWriter writer = new StreamWriter(otherStream);

            int counter = 1;

            while (true)
            {

                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                writer.WriteLine($"{counter}. {line}");

                writer.Flush();

                counter++;
            }
        }
    }
}
