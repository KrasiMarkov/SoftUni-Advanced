using System;
using System.Linq;
namespace Jagged_Array_Modification
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

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "END")
                {
                    break;
                }

                else if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);

                    int col = int.Parse(command[2]);

                    int number = int.Parse(command[3]);

                    if (row >= 0 && row < matrix.GetLength(0))
                    {
                        if (col >= 0 && col < matrix.GetLength(1))
                        {
                            matrix[row, col] += number;
                        }

                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }


                }

                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);

                    int col = int.Parse(command[2]);

                    int number = int.Parse(command[3]);


                    if (row >= 0 && row < matrix.GetLength(0))
                    {
                        if (col >= 0 && col < matrix.GetLength(1))
                        {
                            matrix[row, col] -= number;
                        }

                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");


                }
                Console.WriteLine();

            }
        }
    }
}
