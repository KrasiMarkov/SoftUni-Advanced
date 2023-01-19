using System;
using System.IO;
namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream stream = new FileStream("TextOne.txt", FileMode.OpenOrCreate);

            FileStream anotherStream = new FileStream("TextTwo.txt", FileMode.OpenOrCreate);

            using StreamReader reader = new StreamReader(stream);

            using StreamWriter writer = new StreamWriter(anotherStream);


            int counter = 0;

            while (true)
            {

                var result = reader.ReadLine();

                if (result == null)
                {
                    break;
                }

                if (counter % 2 == 1)
                {
                    writer.WriteLine(result);

                    writer.Flush();

                }


                counter++;

            }

            





        }
    }
}
