﻿using System;
using System.Linq;
namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = arr[0];
            int cols = arr[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = sequence[col];

                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;


            for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
            {

                for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
                {

                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                       + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                       + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;

                        maxRow = row;

                        maxCol = col;


                    }

                }


            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");
        }
    }
}
