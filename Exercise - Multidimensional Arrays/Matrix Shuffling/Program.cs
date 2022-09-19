using System;
using System.Linq;
namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimension[0];

            int cols = dimension[1];

            string[,] matrix = new string[rows, cols];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] sequence = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = sequence[col];


                }

            }

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "END")
                {
                    break;
                }
                else if (command.Length == 5)
                {
                    if (command[0] == "swap")
                    {

                        int row1 = int.Parse(command[1]);

                        int col1 = int.Parse(command[2]);

                        int row2 = int.Parse(command[3]);

                        int col2 = int.Parse(command[4]);

                        if (row1 >= 0 && row1 < matrix.GetLength(0))
                        {
                            if (col1 >= 0 && col1 < matrix.GetLength(1))
                            {
                                if (row2 >= 0 && row2 < matrix.GetLength(0))
                                {
                                    if (col2 >= 0 && col2 < matrix.GetLength(1))
                                    {
                                        string firstNumber = matrix[row1, col1];

                                        string secondNumber = matrix[row2, col2];

                                        matrix[row1, col1] = secondNumber;

                                        matrix[row2, col2] = firstNumber;

                                        for (int row = 0; row < matrix.GetLength(0); row++)
                                        {
                                            for (int col = 0; col < matrix.GetLength(1); col++)
                                            {
                                                string current = matrix[row, col];

                                                Console.Write($"{current} ");
                                            }
                                            Console.WriteLine();
                                        }


                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }

        }
    }
}
