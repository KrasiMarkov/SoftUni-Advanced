using System;
using System.IO;
using System.Text;
namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(".");

            var totalSize = 0m;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                totalSize += fileInfo.Length;
            }

            

            using StreamWriter writer = new StreamWriter("output.txt");

            var final = $"{(totalSize / 1024 / 1024):F4} MB";

            writer.Write(final);

            writer.Flush();
        }
    }
}
