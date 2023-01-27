using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("TextFile1.txt", FileMode.OpenOrCreate);

            using StreamReader reader = new StreamReader(stream);

            

            for (int i = 0; i < stream.Length; i++)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        char symbol = line[j];

                        if (symbol == '.' || symbol == ',' || symbol == '!' || symbol == '?' || symbol == '-')
                        {
                            char finalSymbol = '@';

                            line = line.Replace(symbol, finalSymbol);
                        }
                    }

                    string[] myArr = line.Split().ToArray();

                    myArr = myArr.Reverse().ToArray();

                    Console.WriteLine(string.Join(" ", myArr));

                }
                
            }

            
        }
    }
}
