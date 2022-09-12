using System;
using System.Linq;
namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = sequence[col];



                }


            }

            int sumFirstMatrix = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                
                
                    sumFirstMatrix += matrix[row, row];

                   

                


            }

            int sumSecondMatrix = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int row = matrix.GetLength(0) - i - 1;

                int col = i;

                sumSecondMatrix += matrix[row, col];
            }

            int difference = Math.Abs(sumFirstMatrix - sumSecondMatrix);

            Console.WriteLine(difference);

            
        }
    }
}
