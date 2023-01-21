using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream words = new FileStream("Words.txt", FileMode.OpenOrCreate);

            FileStream text = new FileStream("Text.txt", FileMode.OpenOrCreate);

            FileStream output = new FileStream("Output.txt", FileMode.OpenOrCreate);

            using StreamReader readerWords = new StreamReader(words);

            using StreamReader readerText = new StreamReader(text);

            using StreamWriter writer = new StreamWriter(output);

            List<string> myListText = new List<string>();

            List<string> myListWords = readerWords.ReadLine().Split().ToList();

            var wordPattern = @"\b[A-Za-z]+\b";

            var rgx = new Regex(wordPattern);

            MatchCollection matches = rgx.Matches(readerText.ReadToEnd());

            myListText.AddRange(matches.Cast<Match>().Select(x => x.Value.ToLower()).ToList());

            Dictionary<string, int> myDic = new Dictionary<string, int>();

            for (int i = 0; i < myListWords.Count; i++)
            {
                string currentWords = myListWords[i];

                for (int j = 0; j < myListText.Count; j++)
                {

                    string currentText = myListText[j];

                    if (currentWords == currentText)
                    {
                        if (!myDic.ContainsKey(currentWords))
                        {
                            myDic[currentWords] = 0;
                        }

                        myDic[currentWords]++;
                    }

                }


            }

            var newList = myDic.OrderByDescending(x => x.Value).ToList();

            foreach (var match in newList)
            {
                string word = $"{match.Key} - {match.Value}";

                writer.WriteLine(word);

                writer.Flush();

                
            }



        }
    }
}
