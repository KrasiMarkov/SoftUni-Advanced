﻿using System;
using System.Linq;
namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = myArr[0];

            int cols = myArr[1];


            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];




                }




            }


            int maxSum = int.MinValue;
            int maxRow = int.MinValue;
            int maxCol = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {

                  int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;

                    }
                }


            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
