using System;
using System.Linq;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] matrix = new char[rowsAndColumns[0], rowsAndColumns[1]];
            int times = 0;


            for (int rows = 0; rows < rowsAndColumns[0]; rows++)
            {
                var rowValues = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int cols = 0; cols < rowsAndColumns[1]; cols++)
                {
                    matrix[rows, cols] = rowValues[cols];
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols] && matrix[rows,cols] == matrix[rows,cols+1]
                        && matrix[rows,cols] == matrix[rows+1,cols+1])
                    {
                        times++;
                    }
                }
            }

            Console.WriteLine(times);
        }
    }
}
