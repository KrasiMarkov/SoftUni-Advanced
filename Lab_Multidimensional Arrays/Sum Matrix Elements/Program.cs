using System;
using System.Linq;
using System.Collections.Generic;
namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = myArr[0];

            int cols = myArr[1];


            int[,] matrix = new int[rows, cols];

            Console.WriteLine(rows);

            Console.WriteLine(cols);

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];




                }




            }

            int sum = 0;

            foreach (var item in matrix)
            {
                sum += item;


            }
            Console.WriteLine(sum);

        }
    }
}
