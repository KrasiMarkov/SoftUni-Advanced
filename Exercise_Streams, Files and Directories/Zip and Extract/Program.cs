using System;
using System.IO.Compression;
namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "batman.jpg";

            using ZipArchive zipArchive = ZipFile.Open("../../../arhiv.zip", ZipArchiveMode.Create);

            zipArchive.CreateEntryFromFile(filePath, filePath);
        }
    }
}
