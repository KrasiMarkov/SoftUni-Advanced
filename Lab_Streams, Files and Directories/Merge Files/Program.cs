using System;
using System.IO;
namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream inputOne = new FileStream("InputOne.txt", FileMode.OpenOrCreate);

            FileStream inputTwo = new FileStream("InputTwo.txt", FileMode.OpenOrCreate);

            FileStream output = new FileStream("output.txt", FileMode.OpenOrCreate);

            using StreamReader readerOne = new StreamReader(inputOne);

            using StreamReader readerTwo = new StreamReader(inputTwo);

            using StreamWriter writer = new StreamWriter(output);

            while (true)
            {
                string lineInputOne = readerOne.ReadLine();

                string lineInputTwo = readerTwo.ReadLine();

                if (lineInputOne == null && lineInputTwo == null)
                {
                    break;
                }

                writer.WriteLine(lineInputOne);

                writer.WriteLine(lineInputTwo);

                writer.Flush();
            }

        }
    }
}
