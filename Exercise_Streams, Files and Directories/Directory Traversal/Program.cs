using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @".";

            string searchExtension = ".";

            string[] files = Directory.GetFiles(path, $"*{searchExtension}*");

            Dictionary<string, Dictionary<string, double>> data = new Dictionary<string, Dictionary<string, double>>();

            foreach (var item in files)
            {
                FileInfo info = new FileInfo(item);

                string name = info.Name;

                string extension = info.Extension;

                double length = info.Length / 1024.0;

                if (!data.ContainsKey(extension))
                {
                    data.Add(extension, new Dictionary<string, double>());
                }

                data[extension].Add(name, length);

            }

            StringBuilder sb = new StringBuilder();



            foreach (var item in data.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.AppendLine($"{item.Key}");

                foreach (var itemm in item.Value.OrderBy(x => x.Value))
                {

                    sb.AppendLine($"--{itemm.Key} - {itemm.Value:F3}kb");

                }

            }

            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string resultPath = Path.Combine(pathDesktop, "report.txt");

            File.WriteAllText(resultPath, sb.ToString());

        }
    }
}
