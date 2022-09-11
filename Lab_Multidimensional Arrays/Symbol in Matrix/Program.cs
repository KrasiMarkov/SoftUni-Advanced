using System;
using System.Linq;
namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];



            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                string someString = Console.ReadLine();

                for (int i = 0; i < someString.Length; i++)
                {



                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        char symbol = someString[i];

                        matrix[row, col] = symbol;


                        i++;


                    }





                }




            }

            

            char finalChar = char.Parse(Console.ReadLine());

           

            bool flag = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (matrix[row, col] == finalChar)
                    {

                        Console.WriteLine($"{(row, col)}");

                        flag = true;

                        break;
                    }

                    if (flag == true)
                    {
                        break;
                    }

                }



            }

            if (flag == false)
            {
                Console.WriteLine($"{finalChar} does not occur in the matrix");

            }


        }
    }
}
