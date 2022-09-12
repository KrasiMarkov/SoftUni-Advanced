using System;
using System.Linq;
namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimension[0];

            int cols = dimension[1];

            char[,] matrix = new char[rows, cols];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] symbols = Console.ReadLine().Split().ToArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = char.Parse(symbols[col]);


                }



            }

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currentSymbol = matrix[row, col];

                    if (currentSymbol == matrix[row, col + 1] && currentSymbol == matrix[row + 1, col] && currentSymbol == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }



                }


            }

            Console.WriteLine(counter);
        }
    }
}
