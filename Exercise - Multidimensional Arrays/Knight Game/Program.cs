using System;
using System.Linq;
namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string sequence = Console.ReadLine();

                for (int i = 0; i < sequence.Length; i++)
                {



                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char symbol = sequence[i];

                        matrix[row, col] = symbol;

                        i++;
                    }





                }
            }

            int counter = 0;

            while (true)
            {
                int maxAttackedKnights = 0;

                int maxAttackedKnightsRow = -1;

                int maxAttackedKnightsCol = -1;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        char symbol = matrix[row, col];

                        if (symbol == 'K')
                        {

                            int N = matrix.GetLength(0);



                            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                            {
                                counter++;
                            }

                            if (row - 2 >= 0 && col + 1 < N && matrix[row - 2, col + 1] == 'K')
                            {
                                counter++;
                            }

                            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
                            {
                                counter++;
                            }

                            if (row - 1 >= 0 && col + 2 < N && matrix[row - 1, col + 1] == 'K')
                            {
                                counter++;
                            }

                            if (row + 1 < N && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
                            {
                                counter++;
                            }

                            if (row + 1 < N && col + 2 < N && matrix[row + 1, col + 2] == 'K')
                            {
                                counter++;
                            }

                            if (row + 2 < N && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                            {
                                counter++;
                            }

                            if (row + 2 < N && col + 1 < N && matrix[row + 2, col + 1] == 'K')
                            {
                                counter++;
                            }

                            if (counter > maxAttackedKnights)
                            {
                                maxAttackedKnights = counter;

                                maxAttackedKnightsRow = row;

                                maxAttackedKnightsCol = col;
                            }
                        }
                    }


                }

                if (maxAttackedKnights == 0)
                {
                    break;
                }

                matrix[maxAttackedKnightsRow, maxAttackedKnightsCol] = '0';

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
