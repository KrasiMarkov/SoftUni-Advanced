﻿using System;
using System.Linq;
namespace Sum_Matrix_Columns
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
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];




                }




            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    sum += matrix[row, col];


                }

                Console.WriteLine(sum);


            }


        }
    }
}
