using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("TextInput.txt", FileMode.OpenOrCreate);

            using StreamReader reader = new StreamReader(stream);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < stream.Length; i++)
            {

                string line = reader.ReadLine();

                int countLetters = 0;

                int countSymbols = 0;

                if (line == null)
                {
                    break;
                }

                for (int j = 0; j < line.Length; j++)
                {


                    char current = line[j];

                    if (char.IsLetter(current))
                    {
                        countLetters++;
                    }
                    else if (char.IsPunctuation(current))
                    {
                        countSymbols++;
                    }
                }

                sb.AppendLine($"Line {i + 1}: {line} ({countLetters})({countSymbols})");


            }

            File.WriteAllText("TextOutput.txt", sb.ToString());
        }
    }
}
