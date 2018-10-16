using System;
using System.Linq;
namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.None).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var rowValues = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowValues[cols];
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    int currentSum = matrix[rows,cols] + matrix[rows + 1, cols] + matrix[rows,cols+1] + matrix[rows+1,cols+1];
                    if(currentSum >  maxSum)
                    {
                        maxSum = currentSum;
                        startCol = cols;
                        startRow = rows;
                    }
                }
            }

            Console.WriteLine(matrix[startRow, startCol] + " " +matrix[startRow, startCol + 1]);
            Console.WriteLine(matrix[startRow + 1, startCol] + " " + matrix[startRow + 1, startCol + 1]);
            Console.WriteLine(maxSum);
            Console.ReadKey();
        }
    }
}
