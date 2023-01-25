using System;
using System.IO;
using System.Linq;
namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream stream = new FileStream("batman.jpg", FileMode.Open);

            using FileStream streamOutput = new FileStream("newBatman.jpg", FileMode.Create);

            byte[] buffer = new byte[4096];


            while (true)
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    break;
                }

               

                streamOutput.Write(buffer);
            }
        }
    }
}
