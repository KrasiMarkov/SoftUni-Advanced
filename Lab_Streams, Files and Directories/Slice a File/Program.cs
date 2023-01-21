using System;
using System.IO;
using System.Text;
using System.Linq;
namespace Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream stream = new FileStream("InputPart.txt", FileMode.OpenOrCreate);

            var parts = 4;

            var lenght = (int)Math.Ceiling(stream.Length / (decimal)parts);

            byte[] buffer = new byte[lenght];


            for (int i = 0; i < parts; i++)
            {

                var bytesRead = stream.Read(buffer, 0, buffer.Length);

                if (bytesRead < buffer.Length)
                {
                    buffer = buffer.Take(bytesRead).ToArray();
                }

                

                using FileStream output = new FileStream($"Part{i + 1}.txt", FileMode.OpenOrCreate);

                output.Write(buffer, 0, buffer.Length);

                


            }

            






        }
    }
}
