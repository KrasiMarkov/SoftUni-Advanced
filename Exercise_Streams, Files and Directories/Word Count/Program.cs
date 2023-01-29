using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream streamWord = new FileStream("words.txt", FileMode.OpenOrCreate);

            FileStream streamText = new FileStream("Text.txt", FileMode.OpenOrCreate);

            using StreamReader readerWord = new StreamReader(streamWord);

            using StreamReader readerText = new StreamReader(streamText);

            using StreamWriter writer = new StreamWriter("actualResult.txt");

            using StreamWriter writerFinal = new StreamWriter("expectedResult.txt");

            Dictionary<string, int> myDic = new Dictionary<string, int>();

            var wordPattern = @"\b[A-Za-z]+\b";

            var rgx = new Regex(wordPattern);

            MatchCollection matches = rgx.Matches(readerText.ReadToEnd().ToLower());

            while (true)
            {
                string word = readerWord.ReadLine();

                if (word == null)
                {
                    break;
                }

                

                foreach (var item in matches)
                {
                    string current = item.ToString();

                    if (current == word)
                    {
                        if (!myDic.ContainsKey(current))
                        {
                            myDic[current] = 0;
                        }

                        myDic[current]++;
                    }


                }


            }

            foreach (var item in myDic)
            {

                var current = $"{item.Key} - {item.Value}";

                writer.WriteLine(current);

                writer.Flush();

            }

            foreach (var item in myDic.OrderByDescending(x => x.Value))
            {
                var current = $"{item.Key} - {item.Value}";

                writerFinal.WriteLine(current);

                writerFinal.Flush();
            }
        }
    }
}
